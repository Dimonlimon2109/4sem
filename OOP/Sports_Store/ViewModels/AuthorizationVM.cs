using GalaSoft.MvvmLight;
using Microsoft.Win32;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Sports_store.Command;
using Sports_store.Models;
using Sports_store.Views;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Image = SixLabors.ImageSharp.Image;

namespace Sports_store.ViewModels
{

    public enum View
    {
        LogIn,
        Registration
    }
    public class AuthorizationVM : ViewModelBase
    {

        private View currentView;

        public View CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                RaisePropertyChanged(nameof(CurrentView));
            }
        }
        private List<UserControl> userControls;

        public List<UserControl> UserControls
        {
            get
            {
                return userControls;
            }
            set
            {
                userControls = value;
                RaisePropertyChanged(nameof(UserControls));
            }
        }

        private UserControl currentUserControl;

        public UserControl CurrentUserControl
        {
            get
            {
                return currentUserControl;
            }
            set
            {
                currentUserControl = value;
                RaisePropertyChanged(nameof(currentUserControl));
            }
        }

        private string currentLogin = string.Empty;
        public string CurrentLogin
        {
            get
            {
                return currentLogin;
            }
            set
            {
                currentLogin = value;
                RaisePropertyChanged(nameof(CurrentLogin));
            }
        }

        private string currentPassword = string.Empty;

        public string CurrentPassword
        {
            get => currentPassword;
            set
            {
                currentPassword = value;
                RaisePropertyChanged(nameof(CurrentPassword));
            }
        }
        public AuthorizationVM()
        {
            GlobalResources.Context = new Database.SportsContext();
            userControls = new List<UserControl>();
            userControls.Add(new LogIn());
            userControls.Add(new Registration());
            currentUserControl = userControls.First();
            CurrentUser = new User();
        }

        private MyCommand goToMain;

        public MyCommand GoToMain
        {
            get
            {
                return goToMain ??
                    (goToMain = new MyCommand((obj) =>
                    {
                        User found_user = GlobalResources.Context.Users.Where(u => u.Login.Equals(CurrentLogin)).FirstOrDefault();
                        if (ValidateAuth(found_user))
                        {
                            GlobalResources.CurrentUser = found_user;
                            Main main_page = new Main();
                            Application.Current.MainWindow.Close();
                            main_page.Show();
                        }
                    }));
            }
        }

        private bool ValidateAuth(User found_user)
        {
            PasswordError = string.Empty;
            LoginError = string.Empty;
            bool isValid = true;
            if (CurrentPassword == string.Empty && CurrentLogin == string.Empty)
            {
                PasswordError = "Введите пароль";
                LoginError = "Введите логин";
                isValid = false;
            }
            else if (CurrentLogin == string.Empty)
            {
                LoginError = "Введите логин";
                isValid = false;
            }
            else if (CurrentPassword == string.Empty)
            {
                PasswordError = "Введите пароль";
                isValid = false;
            }
            else if (found_user == null)
            {
                LoginError = "Такой пользователь не существует";
                isValid = false;

            }
            else if (CurrentPassword.Length < 8)
            {
                PasswordError = "Пароль должен быть больше 8 символов";
                isValid = false;
            }
            else if (found_user != null && !found_user.Password.Equals(CurrentPassword))
            {
                PasswordError = "Неверный пароль";
                isValid = false;
            }
            return isValid;
        }

        private string loginError = string.Empty;
        private string passwordError = string.Empty;

        public string LoginError
        {
            get
            {
                return loginError;
            }
            set
            {
                loginError = value;
                RaisePropertyChanged(nameof(LoginError));
            }
        }

        public string PasswordError
        {
            get
            {
                return passwordError;
            }
            set
            {
                passwordError = value;
                RaisePropertyChanged(nameof(passwordError));
            }
        }

        private MyCommand goToReg;
        public MyCommand GotoReg
        {
            get
            {
                return goToReg ??
                    (goToReg = new MyCommand((obj) =>
                    {
                        CurrentView = View.Registration;
                        CurrentUserControl = userControls[(int)CurrentView];
                        Application.Current.MainWindow.Width = 770;
                        Application.Current.MainWindow.Height = 500;
                    }));
            }
        }

        private User currentUser;
        public User CurrentUser
        {
            get { return currentUser; }
            set
            {
                currentUser = value;
                RaisePropertyChanged(nameof(currentUser));
            }
        }
        private MyCommand addImage;
        public MyCommand AddImage
        {
            get
            {
                return addImage ?? (
                    addImage = new MyCommand(obj =>
                    {
                        OpenFileDialog opf = new OpenFileDialog();
                        opf.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
                        if (opf.ShowDialog() == true)
                        {
                            // Загрузить изображение из файла
                            using (var img = Image.Load(opf.FileName))
                            {
                                // Изменить размер изображения
                                img.Mutate(x => x.Resize(new ResizeOptions
                                {
                                    Size = new SixLabors.ImageSharp.Size(200, 150), // Изменить на желаемый размер
                                    Mode = SixLabors.ImageSharp.Processing.ResizeMode.Stretch // Режим изменения размера
                                }));

                                // Преобразовать изображение в байтовый массив
                                using (var stream = new MemoryStream())
                                {
                                    img.SaveAsJpeg(stream);
                                    CurrentUser.Image = stream.ToArray();
                                }
                            }
                        }
                    }));
            }
        }

        private MyCommand backToAuth;

        public MyCommand BackToAuth
        {
            get
            {
                return backToAuth ??= new MyCommand((obj) =>
                {
                    CurrentUserControl = UserControls[(int)View.LogIn];
                    Application.Current.MainWindow.Width = 400;
                    Application.Current.MainWindow.Height = 400;
                });
            }
        }

        private MyCommand completeRegistration;

        public MyCommand CompleteRegistration
        {
            get
            {
                return completeRegistration ?? (
                    completeRegistration = new MyCommand(obj =>
                    {
                        if (ValidateReg())
                        {
                            GlobalResources.Context.Users.Add(currentUser);
                            GlobalResources.Context.SaveChanges();
                            CurrentUserControl = UserControls[(int)View.LogIn];
                            Application.Current.MainWindow.Width = 400;
                            Application.Current.MainWindow.Height = 400;
                            CurrentUser = new User();
                        }
                    }));
            }
        }

        private MyCommand exit;

        public MyCommand Exit
        {
            get
            {
                return exit ??= new MyCommand((obj) =>
                {
                    Application.Current.Shutdown();
                });

            }
        }

        private MyCommand hide;

        public MyCommand Hide
        {
            get
            {
                return hide ??= new MyCommand((obj) =>
                {
                    Application.Current.MainWindow.WindowState = WindowState.Minimized;
                });

            }
        }

        public string RegLoginError { get => regLoginError; set { regLoginError = value; RaisePropertyChanged(nameof(RegLoginError)); } }
        public string RegPasswordError { get => regPasswordError; set { regPasswordError = value; RaisePropertyChanged(nameof(RegPasswordError)); } }
        public string NameError { get => nameError; set { nameError = value; RaisePropertyChanged(nameof(NameError)); } }
        public string SurnameError { get => surnameError; set { surnameError = value; RaisePropertyChanged(nameof(SurnameError)); } }
        public string EmailError { get => emailError; set { emailError = value; RaisePropertyChanged(nameof(EmailError)); } }
        public string PhoneError { get => phoneError; set { phoneError = value; RaisePropertyChanged(nameof(PhoneError)); } }

        ////////Validation registration
        private string regLoginError = string.Empty;
        private string regPasswordError = string.Empty;
        private string nameError = string.Empty;
        private string surnameError = string.Empty;
        private string emailError = string.Empty;
        private string phoneError = string.Empty;

        private bool ValidateReg()
        {
            if(CurrentUser.Image == null)
            {
                MessageBox.Show("Выберите изображение профиля!");
            }
            bool isValid = true;
            if (CurrentUser.Login.Length < 4)
            {
                RegLoginError = "Введите больше 4 символов";
                isValid = false;
            }
            if (GlobalResources.Context.Users.Where(u => u.Login == CurrentUser.Login).Count() > 0)
            {
                RegLoginError = "Пользователь с таким логином уже существует";
                isValid = false;
            }
            if (CurrentUser.Password.Length < 8)
            {
                RegPasswordError = "Введите больше 8 символов";
                isValid = false;
            }
            if (CurrentUser.Name != null && !Regex.IsMatch(CurrentUser.Name, "^\\p{L}+$"))
            {
                NameError = "Имя содержит только буквы";
                isValid = false;
            }
            if(CurrentUser.Surname == "" || CurrentUser.Surname == null)
            {
                SurnameError = "Поле не должно быть пустым";
                isValid = false;
            }
            if (CurrentUser.Name == "" || CurrentUser.Name == null)
            {
                NameError = "Поле не должно быть пустым";
                isValid = false;
            }
            if (CurrentUser.Surname != null && !Regex.IsMatch(CurrentUser.Surname, "^\\p{L}+$"))
            {
                SurnameError = "Только буквы";
                isValid = false;
            }
            if (!Regex.IsMatch(CurrentUser.PhoneNumber, "^\\+375\\d{9}$"))
            {
                PhoneError = "Введите +375 и 9 цифр";
                isValid = false;
            }
            if (GlobalResources.Context.Users.Where(u => u.PhoneNumber == CurrentUser.PhoneNumber).Count() > 0)
            {
                PhoneError = "Номер уже используется";
                isValid = false;
            }
            if (GlobalResources.Context.Users.Where(u => u.Email == CurrentUser.Email).Count() > 0)
            {
                PhoneError = "Email уже используется";
                isValid = false;
            }
            if (!Regex.IsMatch(CurrentUser.Email, "^[^\\s@]+@[a-z]{2,5}\\.[a-z]{2,3}$"))
            {
                EmailError = "Неверный формат email";
                isValid = false;
            }
            return isValid;
        }
    }
}

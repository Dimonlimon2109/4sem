using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Sports_store.Command;
using Sports_store.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace Sports_store.ViewModels
{
    public class ProfileVM : ViewModelBase
    {

        public ObservableCollection<Order> UserOrders { get; set; }

        public ObservableCollection<Order> Orders { get; set; }

        private User _CurrentUser;

        public User CurrentUser { get { return _CurrentUser; } set { _CurrentUser = value; RaisePropertyChanged(nameof(CurrentUser)); } }

        private string newPassword;

        public string NewPassword { get => newPassword; set { newPassword = value; RaisePropertyChanged(nameof(NewPassword)); } }

        private string confirmPassword;

        public string ConfirmPassword { get => confirmPassword; set { confirmPassword = value; RaisePropertyChanged(nameof(ConfirmPassword)); } }

        private string findStroke;
        public string FindStroke
        {
            get => findStroke;
            set
            {
                findStroke = value;
                RaisePropertyChanged(nameof(FindStroke));
            }
        }
        public ObservableCollection<Order> FilteredOrders { get; set; }
        public ObservableCollection<Order> FilteredUserOrders { get; set; }

        private MyCommand findOrders;

        public MyCommand FindOrders
        {
            get
            {
                return findOrders ??= new MyCommand(obj =>
                {
                    if (CurrentUser.IsAdmin == 0)
                    {
                        FilteredUserOrders = new ObservableCollection<Order>(UserOrders.Where(item => item.OrderGoods.ToLower().Contains(FindStroke.ToLower())));
                        RaisePropertyChanged(nameof(FilteredUserOrders));
                    }
                    else
                    {
                        var ordersgoods = new ObservableCollection<Order>(Orders.Where(item => item.OrderGoods.ToLower().Contains(FindStroke.ToLower())));
                        var namesurname = new ObservableCollection<Order>(Orders.Where(item =>
                        {
                            string fio = item.User.Name + " " + item.User.Surname;
                            return fio.ToLower().Contains(FindStroke.ToLower());
                        }));
                        var login = new ObservableCollection<Order>(Orders.Where(item => item.User.Login.ToLower().Contains(FindStroke.ToLower())));
                        FilteredOrders = new ObservableCollection<Order>(ordersgoods.Union(namesurname.Union(login)));
                        RaisePropertyChanged(nameof(FilteredOrders));
                    }
                });
            }
        }

        private MyCommand saveChanges;

        public MyCommand SaveChanges
        {
            get
            {
                return saveChanges ??= new MyCommand(obj =>
                {
                    if (NewPassword != null)
                    {
                        if (NewPassword != ConfirmPassword)
                            MessageBox.Show("Пароли в обоих полях должны совпадать");
                         else if (NewPassword.Length < 8)
                            MessageBox.Show("Пароль должен быть длинной в 8 и более символов");
                    }
                        if (CurrentUser.Name == "" || CurrentUser.Surname == "")
                            MessageBox.Show("Поля \"Имя\" и \"Фамилия\" не должны быть пустыми");
                    else
                    {
                        if (NewPassword != null)
                            CurrentUser.Password = NewPassword;
                        GlobalResources.Context.Users.Update(CurrentUser);
                        GlobalResources.Context.SaveChanges();
                        MessageBox.Show("Данные успешно сохранены!");
                    }
                });
            }
        }
        public ProfileVM()
        {
            CurrentUser = GlobalResources.CurrentUser;
            if (CurrentUser.IsAdmin == 0)
            {
                UserOrders = new ObservableCollection<Order>(GlobalResources.Context.Orders.AsNoTracking().Where(o => o.UserId == CurrentUser.Id));
                FilteredUserOrders = UserOrders;
            }
            else
            {
                Orders = new ObservableCollection<Order>(GlobalResources.Context.Orders.AsNoTracking().Include(o => o.User));
                FilteredOrders = Orders;
            }
            Messenger.Default.Register<Order>(this, order =>
            {
                UserOrders.Add(order);
            });
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Sports_store.Command;
using Sports_store.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace Sports_store.ViewModels
{
    public class GoodPageVM : ViewModelBase
    {

        private bool isAdmin;

        public bool IsAdmin { get { return isAdmin; } set { isAdmin = value; RaisePropertyChanged(nameof(IsAdmin)); } }

        private Good currentGood;

        public Good CurrentGood
        {
            get { return currentGood; }

            set { currentGood = value; RaisePropertyChanged(nameof(CurrentGood)); }
        }

        private ObservableCollection<Review> reviews;

        public ObservableCollection<Review> Reviews { get { return reviews; } set { reviews = value; RaisePropertyChanged(nameof(Reviews)); } }


        private int reviewsNumber;

        public int ReviewsNumber { get => reviewsNumber; set { reviewsNumber = value; RaisePropertyChanged(nameof(ReviewsNumber)); } }

        private bool isUpdate = false;

        public bool IsUpdate
        {
            get { return isUpdate; }
            set { isUpdate = value; RaisePropertyChanged(nameof(IsUpdate)); }
        }

        private MyCommand updateGood;

        public MyCommand UpdateGood
        {
            get
            {
                return updateGood ??= new MyCommand(obj =>
                {
                    if (CurrentGood.Name.Length == 0 || CurrentGood.Name == null)
                        MessageBox.Show("Название не может быть пустым или содержать только пробелы");
                    else if (CurrentGood.Image == null)
                        MessageBox.Show("Выберите изображение");
                    else if (CurrentGood.Cost == 0)
                        MessageBox.Show("Цена не может быть равна нулю");
                    else
                    IsUpdate = bool.Parse((string)obj);
                    if (!IsUpdate)
                    {
                            if (GlobalResources.Context.Goods.Where(g => g.Id == CurrentGood.Id).Any() && GlobalResources.Context.Goods.Contains(CurrentGood))
                            {
                                GlobalResources.Context.Goods.Update(CurrentGood);
                            }
                            else
                            {
                                GlobalResources.Context.Goods.Add(CurrentGood);
                                Messenger.Default.Send<Good>(CurrentGood, "to catalog");
                            }
                            GlobalResources.Context.SaveChanges();
                            Messenger.Default.Send<string>("update");
                            Messenger.Default.Send<Pages>(Pages.Catalog);
                    }
                });
            }
        }

        private MyCommand deleteGood;

        public MyCommand DeleteGood
        {
            get
            {
                return deleteGood ??= new MyCommand(obj =>
                {

                    GlobalResources.Context.Goods.Remove(GlobalResources.Context.Goods.Find(CurrentGood.Id));
                    GlobalResources.Context.SaveChanges();
                    Messenger.Default.Send<string>("", "remove");
                    Messenger.Default.Send<string>("update");
                    Messenger.Default.Send<Pages>(Pages.Catalog);
                });
            }
        }

        private MyCommand changeImage;
        public MyCommand ChangeImage
        {
            get
            {
                return changeImage ?? (
                    changeImage = new MyCommand(obj =>
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
                                    Size = new SixLabors.ImageSharp.Size(500, 500), // Изменить на желаемый размер
                                    Mode = SixLabors.ImageSharp.Processing.ResizeMode.Stretch // Режим изменения размера
                                }));

                                // Преобразовать изображение в байтовый массив
                                using (var stream = new MemoryStream())
                                {
                                    img.SaveAsJpeg(stream);
                                    CurrentGood.Image = stream.ToArray();
                                }
                            }
                        }
                    }, (_) => isUpdate));
            }
        }

        private Review currentReview = new Review();

        public Review CurrentReview { get { return currentReview; } set { currentReview = value; RaisePropertyChanged(nameof(CurrentReview)); } }

        private MyCommand addReview;

        public MyCommand AddReview
        {
            get
            {
                return addReview ??= new MyCommand(obj =>
                {
                    try
                    {
                        CurrentReview.UserId = GlobalResources.CurrentUser.Id;
                        CurrentReview.GoodId = CurrentGood.Id;
                        CurrentReview.User = GlobalResources.Context.Users.Find(GlobalResources.CurrentUser.Id);
                        CurrentReview.Good = GlobalResources.Context.Goods.Find(CurrentGood.Id);
                        CurrentReview.Date = DateOnly.FromDateTime(DateTime.Now);
                        GlobalResources.Context.Reviews.Add(CurrentReview);
                        Good curgood = GlobalResources.Context.Goods.Where(g => g.Id == CurrentGood.Id).FirstOrDefault();
                        curgood.Rating = (Reviews.Sum(r => r.Rating) + CurrentReview.Rating) / (Reviews.Count() + 1);
                        CurrentGood.Rating = curgood.Rating;
                        GlobalResources.Context.Goods.Update(curgood);
                        GlobalResources.Context.SaveChanges();
                        Reviews.Add(CurrentReview);
                        CurrentReview = new Review();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
        }


        private MyCommand addToBasket;

        public MyCommand AddToBasket
        {
            get
            {
                return addToBasket ??= new MyCommand(obj =>
                {
                    Messenger.Default.Send<Good>(CurrentGood, "add to basket");
                });
            }
        }

        public GoodPageVM()
        {

            IsAdmin = GlobalResources.CurrentUser.IsAdmin == 1;
            Categories = GlobalResources.Categories;
            Types = GlobalResources.Types;
            Colors = GlobalResources.Colors;
            Categories.RemoveAt(0);
            Types.RemoveAt(0);
            Colors.RemoveAt(0);

            Messenger.Default.Register<Good>(this, good =>
            {
                CurrentGood = good;
                Reviews = new ObservableCollection<Review>(GlobalResources.Context.Reviews.AsNoTracking().Where(r => r.GoodId == CurrentGood.Id).Include(r => r.User));
                ReviewsNumber = Reviews.Count();
            });
            Messenger.Default.Register<Good>(this, "CreateNew", good =>
            {
                CurrentGood = good;
                IsUpdate = true;
            });
            Messenger.Default.Register<string>(this, "NoUpdate", str =>
            {
                IsUpdate = false;
            });

        }

        private List<string> categories;

        public List<string> Categories
        {
            get
            {
                return categories;
            }
            set
            {
                categories = value;
                RaisePropertyChanged(nameof(Categories));
            }
        }

        private List<string> colors;

        public List<string> Colors
        {
            get
            {
                return colors;
            }
            set
            {
                colors = value;
                RaisePropertyChanged(nameof(Colors));
            }
        }

        private List<string> types;

        public List<string> Types
        {
            get
            {
                return types;
            }
            set
            {
                types = value;
                RaisePropertyChanged(nameof(Types));
            }
        }
    }
}

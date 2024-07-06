using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lab4.Commands;
using System.Diagnostics;

namespace Lab4.Models
{
    public enum Category
    {
        Все = 0,
        All = 0,
        Обувь = 1,
        Shoes = 1,
        Куртка = 2,
        Jacket = 2,
        Штаны = 3,
        Trousers = 3,
        Шорты = 4,
        Shorts = 4,
        Футболка = 5,
        Tshirt = 5,
        Футбол = 6,
        Football = 6,
        Бокс = 7,
        Boxing = 7,
        Баскетбол = 8,
        Basketball = 8
    }

    public enum MyColor
    {
        Все = 0,
        All = 0,
        Черный = 1,
        Black = 1,
        Белый = 2,
        White = 2,
        Серый = 3,
        Gray = 3,
        Оранжевый = 4,
        Orange = 4,
        Красный = 5,
        Red = 5,
        Зеленый = 6,
        Green = 6,
        Синий = 7,
        Blue = 7,
    }

    [Serializable]
    public class Good : INotifyPropertyChanged
    {
        private string _fullName;
        private string _shortName;
        private string _description;
        private string _image;
        private byte _rating;
        private Category _category;
        private MyColor _color;
        private bool _isAvailable;
        private float _price;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
                OnPropertyChanged(nameof(IsFullNameGood));
            }
        }
        public bool IsFullNameGood
        {
            get { return FullName?.Length > 0; }
        }
        public string ShortName
        {
            get { return _shortName; }
            set
            {
                _shortName = value;
                OnPropertyChanged(nameof(ShortName));
                OnPropertyChanged(nameof(IsShortNameGood));
            }
        }
        public bool IsShortNameGood
        {
            get { return ShortName?.Length > 0; }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(IsDescriptionGood));
            }
        }
        public bool IsDescriptionGood
        {
            get { return Description?.Length > 0; }
        }
        public byte Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                OnPropertyChanged(nameof(Rating));
                OnPropertyChanged(nameof(IsRatingGood));
            }
        }
        public bool IsRatingGood
        {
            get
            {
                return (Rating <= 5 && Rating >= 0);
            }
        }
        public string Image
        {
            get { return _image ?? "/Resources/defaultBall.png"; }
            set
            {
                _image = value ?? "/Resources/defaultBall.png";
                OnPropertyChanged("Image");
            }
        }

        public Category Category
        {
            get { return _category; }
            set
            {
                if (value == Category.Все)
                {
                    _category = Category.Обувь;
                }
                else
                {
                    _category = value;
                }
                OnPropertyChanged(nameof(Category));
            }
        }
        public string CategoryStr
        {
            get
            {
                if (App.Language.Name == "ru-RU")
                {
                    switch (_category)
                    {
                        case Category.Все:
                            return "Все";
                        case Category.Обувь:
                            return "Обувь";
                        case Category.Куртка:
                            return "Куртка";
                        case Category.Штаны:
                            return "Штаны";
                        case Category.Шорты:
                            return "Шорты";
                        case Category.Футболка:
                            return "Футболка";
                        case Category.Футбол:
                            return "Футбол";
                        case Category.Баскетбол:
                            return "Баскетбол";
                        case Category.Бокс:
                            return "Бокс";
                    }
                }
                else
                {
                    switch (_category)
                    {
                        case Category.All:
                            return "All";
                        case Category.Shoes:
                            return "Shoes";
                        case Category.Jacket:
                            return "Jacket";
                        case Category.Trousers:
                            return "Trousers";
                        case Category.Shorts:
                            return "Shorts";
                        case Category.Tshirt:
                            return "T-shirt";
                        case Category.Football:
                            return "Football";
                        case Category.Basketball:
                            return "Basketball";
                        case Category.Boxing:
                            return "Boxing";
                    }
                }
                return "Все";
            }
            set
            {
                OnPropertyChanged("CategoryStr");
            }
        }
        public MyColor Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value == MyColor.Все ? MyColor.Black : value;
                OnPropertyChanged(nameof(Color));
            }
        }
        public String ColorStr
        {
            get
            {
                if (App.Language.Name == "ru-RU")
                {
                    switch (_color)
                    {
                        case 0:
                            return "Все";
                        case (MyColor)1:
                            return "Черный";
                        case (MyColor)2:
                            return "Белый";
                        case (MyColor)3:
                            return "Серый";
                        case (MyColor)4:
                            return "Оранжевый";
                        case (MyColor)5:
                            return "Красный";
                        case (MyColor)6:
                            return "Зеленый";
                        case (MyColor)7:
                            return "Синий";
                    }
                }
                else
                {
                    switch (_color)
                    {
                        case 0:
                            return "All";
                        case (MyColor)1:
                            return "Black";
                        case (MyColor)2:
                            return "White";
                        case (MyColor)3:
                            return "Gray";
                        case (MyColor)4:
                            return "Orange";
                        case (MyColor)5:
                            return "Red";
                        case (MyColor)6:
                            return "Green";
                        case (MyColor)7:
                            return "Blue";
                    }
                }
                return MyColor.All.ToString();
            }
            set
            {
                OnPropertyChanged("ColorStr");
            }
        }
        public string IsAvailable
        {
            get
            {
                if (App.Language.Name == "ru-RU")
                {
                    return _isAvailable ? "да" : "нет";
                }
                else
                {
                    return _isAvailable ? "yes" : "no";
                }
            }
        }
        public bool IsAvailableBool
        {
            get { return _isAvailable; }
            set
            {
                _isAvailable = value;
                OnPropertyChanged(nameof(IsAvailable));
                OnPropertyChanged(nameof(IsAvailableBool));
            }
        }
        public float Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(IsPriceGood));
            }
        }

        public bool IsPriceGood
        {
            get { return Price >= 0; }
        }
        public Good()
        {
            Color = MyColor.Black;
        }
        public Good(string fullName, string shortName, string description, byte rating, string image, Category category, MyColor color, bool isAvailable, float price)
        {
            FullName = fullName;
            ShortName = shortName;
            Description = description;
            Rating = rating;
            Image = image;
            Category = category;
            Color = color;
            IsAvailableBool = isAvailable;
            Price = price;
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}

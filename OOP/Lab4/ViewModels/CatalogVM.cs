using Lab4.Commands;
using Lab4.Models;
using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab4.ViewModels
{
    public enum View
    {
        Catalog,
        SelectedItem,
        AddGood
    }
    public enum Colors
    {
        Gray, 
        Pink,
        Blue
    }
    class CatalogVM : INotifyPropertyChanged
    {
        private List<Good> _goods = new List<Good>();

        private static List<Good> _goodsFirst = new List<Good>();

        private Good _selectedGood;

        private Colors theme = Colors.Gray;

        private RelayCommand _changeTheme;

        public Colors Theme
        {
            get
            {
                return theme;
            }
            set
            {
                theme = value;
               OnPropertyChanged("Theme");
            }
        }
        public RelayCommand changeTheme
        {
            get
            {
                return _changeTheme ?? (
                    _changeTheme = new RelayCommand((obj) =>
                    {
                        switch (theme)
                        {
                            case Colors.Gray:
                                Theme = Colors.Pink;
                                _filterVM.Theme = Theme;
                                _child.Theme = Theme;
                                _selectedVM.Theme = Theme;
                                break;
                            case Colors.Pink:
                                Theme = Colors.Blue; _filterVM.Theme = Theme; _child.Theme = Theme; _selectedVM.Theme = Theme; break;
                            case Colors.Blue:
                                Theme = Colors.Gray; _filterVM.Theme = Theme; _child.Theme = Theme; _selectedVM.Theme = Theme; break;
                                default:
                                Theme = Colors.Gray; _filterVM.Theme = Theme; _child.Theme = Theme; _selectedVM.Theme = Theme; break;
                        }
                    }
                    ));
            }
        }

        private RelayCommand returnGood;

        public RelayCommand ReturnGood
        {
            get
            {
                return returnGood ?? (
                    returnGood = new RelayCommand((obj) =>
                    {
                        if (SelectedVM.DeletedGoods.Count != 0)
                        {
                            Goods.Add(SelectedVM.DeletedGoods.Last());
                            GoodsFirst.Add(SelectedVM.DeletedGoods.Last());
                            SelectedVM.ReturnedGoods.Add(SelectedVM.DeletedGoods.Last());
                            SelectedVM.DeletedGoods.Remove(SelectedVM.DeletedGoods.Last());
                            Goods = Goods.ToList();
                        }
                    }));
            }
        }

        private RelayCommand deleteReturnedGood;

        public RelayCommand DeleteReturnedGood
        {
            get
            {
                return deleteReturnedGood ?? (
                    deleteReturnedGood = new RelayCommand((obj) =>
                    {
                        if (SelectedVM.ReturnedGoods.Count() != 0)
                        {
                            GoodsFirst.Remove(SelectedVM.ReturnedGoods.Last());
                            Goods.Remove(SelectedVM.ReturnedGoods.Last());
                            SelectedVM.DeletedGoods.Add(SelectedVM.ReturnedGoods.Last());
                            SelectedVM.ReturnedGoods.Remove(SelectedVM.ReturnedGoods.Last());
                            Goods = Goods.ToList();
                        }
                    }));
            }
        }
        public List<Good> Goods
        {
            get { return _goods; }
            set
            {
                _goods = value;
                OnPropertyChanged("Goods");
            }
        }

        public static List<Good> GoodsFirst
        {
            get { return _goodsFirst; }
        }

        public Good SelectedGood
        {
            get { return _selectedGood; }
            set
            {
                _selectedGood = value;
                SelectedVM.good = SelectedGood;
                View = (View.SelectedItem);
                OnPropertyChanged("SelectedGood");
            }
        }

        private View _view;
        public View View
        {
            get { return _view; }
            set
            {
                _view = value;
                OnPropertyChanged("View");
                FilterVM.OnPropertyChanged("IsViewGood");
            }
        }

        private RelayCommand _backView;
        public RelayCommand BackView
        {
            get
            {
                return _backView ??
                (_backView = new RelayCommand((obj =>
                {
                    SelectedGood = null;
                    View = View.Catalog;
                }
                )
                ));
            }
        }
        private AddVM _child;
        public AddVM Child
        {
            get
            {
                return _child;
            }
        }

        public FilterVM _filterVM;
        public FilterVM FilterVM
        {
            get
            {
                return _filterVM;
            }
        }

        public SelectedVM _selectedVM;
        public SelectedVM SelectedVM
        {
            get
            {
                return _selectedVM;
            }
        }

        private RelayCommand _addGood;
        public RelayCommand AddGood
        {
            get
            {
                return _addGood ??
                    (_addGood = new RelayCommand((obj) =>
                    {
                        View = View.AddGood;
                        _child = new AddVM(this);
                    }));
            }
        }

        private RelayCommand _languageChange;
        public RelayCommand LanguageChange
        {
            get
            {
                return _languageChange ??
                    (_languageChange = new RelayCommand((obj) =>
                    {
                        if (App.Language.Name == "ru-RU")
                        {
                            App.Language = new System.Globalization.CultureInfo("en-US");
                            MainWindow.catBox.ItemsSource = new List<string>()
                            {
                                "All",
                                "Shoes",
                                "Jacket",
                                "Trousers",
                                "Shorts",
                                "T-shirt",
                                "Football",
                                "Boxing",
                                "Basketball"
                            };
                            MainWindow.catBox.SelectedIndex = 0;
                            MainWindow.colBox.ItemsSource = new List<string>()
                            {
                                    "Black",
                                    "White",
                                    "Gray",
                                    "Orange",
                                    "Red",
                                    "Green",
                                    "Blue"
                            };
                            MainWindow.colBox.SelectedIndex = 0;
                            if (Lab4.AddGood.colorBox != null)
                            {
                                Lab4.AddGood.colorBox.ItemsSource = new List<string>()
                                {
                                    "Black",
                                    "White",
                                    "Gray",
                                    "Orange",
                                    "Red",
                                    "Green",
                                    "Blue"
                                };
                                Lab4.AddGood.colorBox.SelectedIndex = 0;
                                Lab4.AddGood.comboBox.ItemsSource = new List<string>()
                                {
                                "All",
                                "Shoes",
                                "Jacket",
                                "Trousers",
                                "Shorts",
                                "T-shirt",
                                "Football",
                                "Boxing",
                                "Basketball"
                                };
                                Lab4.AddGood.comboBox.SelectedIndex = 0;
                            }
                        }
                        else
                        {
                            App.Language = new System.Globalization.CultureInfo("ru-RU");
                            MainWindow.catBox.ItemsSource = new List<string>()
                            {
                                "Все",
                                "Обувь",
                                "Куртка",
                                "Штаны",
                                "Шорты",
                                "Футболка",
                                "Футбол",
                                "Бокс",
                                "Баскетбол"
                            };
                            MainWindow.catBox.SelectedIndex = 0;
                            MainWindow.colBox.ItemsSource = new List<string>()
                            {
                                "Все",
                                "Черный",
                                "Белый",
                                "Серый",
                                "Оранжевый",
                                "Красный",
                                "Зеленый",
                                "Синий"
                            };
                            MainWindow.colBox.SelectedIndex = 0;
                            if (Lab4.AddGood.colorBox != null)
                            {
                                Lab4.AddGood.colorBox.ItemsSource = new List<string>()
                                {
                                "Все",
                                "Черный",
                                "Белый",
                                "Серый",
                                "Оранжевый",
                                "Красный",
                                "Зеленый",
                                "Синий"
                                };
                                Lab4.AddGood.colorBox.SelectedIndex = 0;
                                Lab4.AddGood.comboBox.ItemsSource = new List<string>()
                                {
                                "Все",
                                "Обувь",
                                "Куртка",
                                "Штаны",
                                "Шорты",
                                "Футболка",
                                "Футбол",
                                "Бокс",
                                "Баскетбол"
                                };
                                Lab4.AddGood.comboBox.SelectedIndex = 0;
                            }
                        }
                        if (SelectedVM.SelectedGood != null)
                        {
                            SelectedVM.SelectedGood.IsAvailableBool = SelectedVM.SelectedGood.IsAvailableBool;
                            SelectedVM.SelectedGood.ColorStr = SelectedVM.SelectedGood.ColorStr;
                            SelectedVM.SelectedGood.CategoryStr = SelectedVM.SelectedGood.CategoryStr;
                        }
                    }));
            }
        }
        public void Recover()
        {
            Goods = _goodsFirst.ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        public CatalogVM()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Good>));
                using (FileStream fs = new FileStream("data.xml", FileMode.Open))
                {
                    _goodsFirst = (List<Good>)xmlSerializer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {

            }
            _goods = _goodsFirst.ToList();
            _child = new AddVM(this);
            _filterVM = new FilterVM(this);
            _selectedVM = new SelectedVM(this);
        }
    }
}

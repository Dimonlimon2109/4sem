using Lab4.Commands;
using Lab4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ViewModels
{
    class FilterVM : INotifyPropertyChanged
    {
        private CatalogVM _catalogVM;


        private Colors theme = Colors.Gray;

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

        public bool IsViewGood
        {
            get
            {
                return _catalogVM.View == View.Catalog;
            }
        }

        private Category _category = (Category)6;
        public Category Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }
        private MyColor _color;
        public MyColor Color
        {
            get { return _color; }
            set
            {
                _color = value;
                OnPropertyChanged(nameof(Color));
            }
        }

        private float _minPrice;
        public float MinPrice
        {
            get { return _minPrice; }
            set
            {
                _minPrice = value;
                OnPropertyChanged(nameof(MinPrice));
                OnPropertyChanged(nameof(IsMinPriceGood));
                OnPropertyChanged(nameof(IsMaxPriceGood));
            }
        }

        public bool IsMinPriceGood
        {
            get { return MinPrice >= 0; }
        }

        private float _maxPrice;
        public float MaxPrice
        {
            get { return _maxPrice; }
            set
            {
                _maxPrice = value;
                OnPropertyChanged(nameof(MaxPrice));
                OnPropertyChanged(nameof(IsMaxPriceGood));
            }
        }

        public bool IsMaxPriceGood
        {
            get { return ((MaxPrice >= 0) && (_maxPrice >= _minPrice)); }
        }


        private RelayCommand _filterCommand;

        public RelayCommand FilterCommand
        {
            get
            {
                return _filterCommand ?? (
                    _filterCommand = new RelayCommand((obj) =>
                    {
                        _catalogVM.Recover();
                        _catalogVM.Goods = _catalogVM.Goods.Where(x => x.Price >= MinPrice && x.Price <= MaxPrice).ToList();
                        if (Category != Category.Все)
                        {
                            _catalogVM.Goods = _catalogVM.Goods.Where(x => x.Category == Category).ToList();
                        }
                        if (Color != MyColor.Все)
                        {
                            _catalogVM.Goods = _catalogVM.Goods.Where(x => x.Color == Color).ToList();
                        }
                    },(obj) => { return IsMinPriceGood && IsMaxPriceGood; }));
            }
        }

        private RelayCommand _recoverCommand;
        public RelayCommand RecoverCommand
        {
            get
            {
                return _recoverCommand ?? (
                    _recoverCommand = new RelayCommand((obj) =>
                    {
                        _catalogVM.Recover();
                    }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        public FilterVM(CatalogVM catalogVM)
        {
            _catalogVM = catalogVM;
            try
            {
                MinPrice = _catalogVM.Goods.Min(x => x.Price);
                MaxPrice = _catalogVM.Goods.Max(x => x.Price);
            }
            catch
            {
                MinPrice = 0;
                MaxPrice = 0;
            }
        }

    }
}

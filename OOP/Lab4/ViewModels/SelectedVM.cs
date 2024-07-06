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
    class SelectedVM : INotifyPropertyChanged
    {
        public static Good good;

        private List<Good> _deletedGoods;
        private List<Good> _returnedGoods;

        public List<Good> DeletedGoods
        {
            get { return _deletedGoods; }
            set
            {
                _deletedGoods = value;
                OnPropertyChanged("DeletedGoods");
            }
        }

        public List<Good> ReturnedGoods
        {
            get { return _returnedGoods; }
            set
            {
                _returnedGoods = value;
                OnPropertyChanged("ReturnedGoods");
            }
        }

        public Good SelectedGood
        {
            get { return good; }
            set
            {
                good = value;
                OnPropertyChanged("SelectedGood");
            }
        }
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

        private CatalogVM _catalogVM;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        private RelayCommand _deleteGood;
        public RelayCommand DeleteGood
        {
            get
            {
                return _deleteGood ?? (
                    _deleteGood = new RelayCommand(
                        obj =>
                        {
                            CatalogVM.GoodsFirst.Remove(SelectedGood);
                            _catalogVM.Goods.Remove(SelectedGood);
                            _deletedGoods.Add(SelectedGood);
                            _catalogVM.SelectedGood = null;
                            _catalogVM.View = View.Catalog;
                        }
                        ));
            }
        }

        private RelayCommand _editGood;
        public RelayCommand EditGood
        {
            get
            {
                return _editGood ?? (
                    _editGood = new RelayCommand(obj =>
                    {
                        _catalogVM.Child.IsEditing = true;
                        _catalogVM.Child.CreatingGood = SelectedGood;
                        _catalogVM.View = View.AddGood;
                    }
                    ));
            }
        }

        public SelectedVM(CatalogVM catalog)
        {
            _catalogVM = catalog;
            _deletedGoods = new List<Good>();
            _returnedGoods = new List<Good>();
        }
    }
}

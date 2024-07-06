using Lab4.Commands;
using Lab4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Data;

namespace Lab4.ViewModels
{
    class AddVM
    {
        private readonly CatalogVM _catalogVM;

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
        private Good _creatingGood;
        public Good CreatingGood
        {
            get { return _creatingGood; }
            set
            {
                _creatingGood = value;
                OnPropertyChanged("CreatingGood");
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

        private RelayCommand _addImage;
        public RelayCommand AddImage
        {
            get
            {
                return _addImage ?? (
                    _addImage = new RelayCommand(obj =>
                    {
                        OpenFileDialog opf = new OpenFileDialog();
                        opf.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
                        if (opf.ShowDialog() == true)
                        {
                            CreatingGood.Image = opf.FileName;
                        }
                    }));
            }
        }

        private RelayCommand _createGood;

        public RelayCommand CreateGood
        {
            get
            {
                return _createGood ?? (
                    _createGood = new RelayCommand(obj =>
                    {
                        if (!IsEditing)
                        {
                            CatalogVM.GoodsFirst.Add(CreatingGood);
                            _catalogVM.Goods.Add(CreatingGood);
                        }
                        IsEditing = false;
                        _catalogVM.SelectedGood = null;
                        _catalogVM.View = View.Catalog;
                        _creatingGood = null;
                    }, (_)=>
                    {
                        return
                            _creatingGood != null && (
                            CreatingGood.IsFullNameGood && CreatingGood.IsShortNameGood &&
                            CreatingGood.IsDescriptionGood && CreatingGood.IsPriceGood &&
                            CreatingGood.IsRatingGood);
                    }));
            }
        }

        public bool IsEditing
        {
            get;
            set;
        }

        public AddVM(CatalogVM parent)
        {
            IsEditing = false;
            _catalogVM = parent;
            CreatingGood = new Good();
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Sports_store.Command;
using Sports_store.Models;
using System.Collections.ObjectModel;

namespace Sports_store.ViewModels
{
    public class CatalogVM : ViewModelBase
    {
        public ObservableCollection<Good> Goods { get; set; }

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

        private string searchResult;

        public string SearchResult
        {
            get { return searchResult; }
            set
            {
                searchResult = value;
                RaisePropertyChanged(nameof(SearchResult));
            }
        }

        private string findStroke;

        public string FindStroke { get => findStroke; set { findStroke = value; RaisePropertyChanged(nameof(FindStroke)); } }

        private MyCommand findGoods;

        public MyCommand FindGoods
        {
            get
            {
                return findGoods ??= new MyCommand((obj) =>
                {
                    CatalogGoods = new ObservableCollection<Good>(Goods.Where(item => item.Name.ToLower().Contains(FindStroke.ToLower())).ToList());
                });
            }
        }

        private Good selectedGood;

        public Good SelectedGood
        {
            get => selectedGood;
            set
            {
                selectedGood = value;
                Messenger.Default.Send<Good>(SelectedGood);
                Messenger.Default.Send<Pages>(Pages.GoodPage);
                RaisePropertyChanged(nameof(SelectedGood));
            }
        }

        private ObservableCollection<Good> catalogGoods = new ObservableCollection<Good>();

        public ObservableCollection<Good> CatalogGoods { get { return catalogGoods; } set { catalogGoods = value; RaisePropertyChanged(nameof(CatalogGoods)); } }
        public CatalogVM()
        {
            Categories = GlobalResources.Categories;
            Types = GlobalResources.Types;
            Colors = GlobalResources.Colors;
            Goods = new ObservableCollection<Good>(GlobalResources.Context.Goods.AsNoTracking().Include(g => g.Reviews).ThenInclude(u => u.User));
            CatalogGoods = Goods;
            if (CatalogGoods.Count > 0)
                FilterMaxPrice = CatalogGoods.Max(g => g.Cost);
            else
                FilterMaxPrice = 0;
            FilterType = Types[0];
            FilterCategory = Categories[0];
            FilterColor = Colors[0];
            Messenger.Default.Register<Good>(this, "to catalog", good =>
            {
                Goods.Add(good);
            });
            Messenger.Default.Register<string>(this, str =>
            {
                CatalogGoods = Goods;
                selectedGood = null;
                RaisePropertyChanged(nameof(SelectedGood));
            });

            Messenger.Default.Register<string>(this, "remove", str =>
            {
                Goods.Remove(SelectedGood);
            });
        }

        private string filterCategory;

        public string FilterCategory { get { return filterCategory; } set { if (filterCategory != value) filterCategory = value; RaisePropertyChanged(nameof(FilterCategory)); } }

        private string filterType;

        public string FilterType { get { return filterType; } set { if (filterType != value) { filterType = value; RaisePropertyChanged(nameof(FilterType)); } } }

        private string filterColor;

        public string FilterColor { get { return filterColor; } set { if (filterColor != value) { filterColor = value; RaisePropertyChanged(nameof(FilterColor)); } } }

        private decimal filterMinPrice = 0;

        public decimal FilterMinPrice
        {
            get { return filterMinPrice; }
            set
            {
                if (value < 0)
                    filterMinPrice = 0;
                else if (value > FilterMaxPrice)
                    filterMinPrice = FilterMaxPrice;
                else
                    filterMinPrice = value;
                RaisePropertyChanged(nameof(FilterMinPrice));
            }
        }

        private decimal filterMaxPrice;
        public decimal FilterMaxPrice
        {
            get { return filterMaxPrice; }
            set
            {
                if (value < 0)
                    filterMaxPrice = 0;
                else if (value < FilterMinPrice)
                    filterMaxPrice = filterMinPrice;
                else
                    filterMaxPrice = value;
                RaisePropertyChanged(nameof(FilterMaxPrice));
            }
        }

        private bool inStock = true;

        public bool InStock { get { return inStock; } set { inStock = value; RaisePropertyChanged(nameof(InStock)); } }

        private MyCommand filtering;

        public MyCommand Filtering
        {
            get
            {
                return filtering ??= new MyCommand(obj =>
                {
                    if (InStock)
                        CatalogGoods = new ObservableCollection<Good>(Goods
                            .Where(g => (g.StockQuantity > 0 && g.Cost >= FilterMinPrice && g.Cost <= FilterMaxPrice)));
                    else
                        CatalogGoods = new ObservableCollection<Good>(Goods
                            .Where(g => (g.StockQuantity == 0 && g.Cost >= FilterMinPrice && g.Cost <= FilterMaxPrice)));
                    if (FilterColor != "Любой")
                        CatalogGoods = new ObservableCollection<Good>(CatalogGoods.Where(g => g.Color == FilterColor));
                    if (FilterCategory != "Все")
                        CatalogGoods = new ObservableCollection<Good>(CatalogGoods.Where(g => g.Category == FilterCategory));
                    if (FilterType != "Любой")
                        CatalogGoods = new ObservableCollection<Good>(CatalogGoods.Where(g => g.Type == FilterType));
                });
            }
        }

        private MyCommand resetFilter;

        public MyCommand ResetFilter
        {
            get
            {
                return resetFilter ??= new MyCommand(obj =>
                {
                    CatalogGoods = Goods;
                    FilterType = Types[0];
                    FilterCategory = Categories[0];
                    FilterColor = Colors[0];
                    InStock = true;
                    FilterMinPrice = 0;
                    FilterMaxPrice = Goods.Max(g => g.Cost);
                });
            }
        }
    }
}

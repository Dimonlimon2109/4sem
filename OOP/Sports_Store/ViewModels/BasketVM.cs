using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Sports_store.Command;
using Sports_store.Models;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;

namespace Sports_store.ViewModels
{
    public class BasketVM : ViewModelBase
    {

        public List<string> Payment = new List<string>()
        {
            "Наличные",
            "Банковская карта"
        };

        private ObservableCollection<BasketGood> basketGoods;

        private Order currentOrder;

        public Order CurrentOrder
        {
            get => currentOrder;
            set
            {
                currentOrder = value;
                RaisePropertyChanged(nameof(CurrentOrder));
            }
        }

        public ObservableCollection<BasketGood> BasketGoods { get => basketGoods; set { basketGoods = value; RaisePropertyChanged(nameof(BasketGoods)); } }

        private MyCommand deleteFromBasket;

        public MyCommand DeleteFromBasket
        {
            get
            {
                return deleteFromBasket ??= new MyCommand(obj =>
                {
                    var good = obj as BasketGood;
                    CurrentOrder.TotalCost -= good.TotalCost;
                    GlobalResources.Context.BasketGoods.RemoveRange(GlobalResources.Context.BasketGoods.Where(bg => bg.Id == good.Id));
                    BasketGoods.Remove(good);
                    GlobalResources.Context.SaveChanges();
                });
            }
        }

        private MyCommand minus;

        public MyCommand Minus
        {
            get
            {
                return minus ??= new MyCommand(obj =>
                {
                    var good = obj as BasketGood;
                    if (good.Amount != 1)
                    {
                        good.Amount--;
                        good.TotalCost = good.Good.Cost * good.Amount;
                        var bdgood = GlobalResources.Context.BasketGoods.Where(bg => bg.Id == good.Id).Include(bg => bg.Good).FirstOrDefault();
                        bdgood.Amount--;
                        bdgood.TotalCost = bdgood.Amount * bdgood.Good.Cost;
                        GlobalResources.Context.BasketGoods.Update(bdgood);
                        GlobalResources.Context.SaveChanges();
                        CurrentOrder.TotalCost -= good.Good.Cost;
                    }
                });
            }
        }

        private MyCommand plus;

        public MyCommand Plus
        {
            get
            {
                return plus ??= new MyCommand(obj =>
                {
                    var good = obj as BasketGood;
                    good.Amount++;
                    good.TotalCost = good.Good.Cost * good.Amount;
                    var bdgood = GlobalResources.Context.BasketGoods.Where(bg => bg.Id == good.Id).Include(bg => bg.Good).FirstOrDefault();
                    bdgood.Amount++;
                    bdgood.TotalCost = bdgood.Amount * bdgood.Good.Cost;
                    GlobalResources.Context.BasketGoods.Update(bdgood);
                    GlobalResources.Context.SaveChanges();
                    CurrentOrder.TotalCost += good.Good.Cost;
                });
            }
        }

        private bool cash;

        private bool card;

        public bool Cash
        {
            get { return cash; }
            set { cash = value; if (cash) CurrentOrder.PayMethod = "Наличные"; RaisePropertyChanged(nameof(Cash)); }
        }

        public bool Card
        {
            get { return card; }
            set { card = value; if (card) CurrentOrder.PayMethod = "Банковская карта"; RaisePropertyChanged(nameof(Card)); }
        }

        private bool IsGoodsAvailable()
        {
            bool AllGood = true;
            foreach (var bgood in BasketGoods)
            {
                if (bgood.Amount > bgood.Good.StockQuantity && bgood.Good.StockQuantity != 0)
                {
                    MessageBox.Show("Товар " + bgood.Good.Name + " можно заказать в количестве до " + bgood.Good.StockQuantity + ".\n" +
                        "Выберите другое количество товара");
                    AllGood = false;
                }
                else if (bgood.Good.StockQuantity == 0)
                {
                    MessageBox.Show("Товара " + bgood.Good.Name + " в данный момент нет в наличии");
                    AllGood = false;
                }
            }
            if (!Regex.IsMatch(CurrentOrder.Adress, "г[.]\\s*([А-ЯЁ][а-яё]*)\\s*ул[.]\\s*([А-ЯЁ][а-яё]*)\\s*д[.]\\s*(\\d+)"))
            {
                AllGood = false;
                MessageBox.Show("Введите корректный адрес");
            }
            if (CurrentOrder.PayMethod == null)
            {
                MessageBox.Show("Выберите способ оплаты");
            }
            return AllGood;
        }

        private MyCommand orderingGoods;

        public MyCommand OrderingGoods
        {
            get
            {
                return orderingGoods ??= new MyCommand(obj =>
                {
                    if (IsGoodsAvailable())
                    {
                        foreach (var bgood in BasketGoods)
                        {

                            var orderedGood = GlobalResources.Context.Goods.Where(g => g.Id == bgood.GoodId).FirstOrDefault();
                            orderedGood.StockQuantity -= bgood.Amount;
                            orderedGood.SaledAmount += bgood.Amount;
                            GlobalResources.Context.Goods.Update(orderedGood);
                            GlobalResources.Context.SaveChanges();
                        }
                        CurrentOrder.Date = DateTime.Now;
                        CurrentOrder.BasketToString(BasketGoods);
                        GlobalResources.Context.Orders.Add(CurrentOrder);
                        var deleted_basket = GlobalResources.Context.BasketGoods.Where(bg => bg.UserId == GlobalResources.CurrentUser.Id);
                        GlobalResources.Context.BasketGoods.RemoveRange(deleted_basket);
                        BasketGoods = new ObservableCollection<BasketGood>();
                        Messenger.Default.Send<Order>(CurrentOrder);
                        GlobalResources.Context.SaveChanges();
                        CurrentOrder = new Order();
                        Card = false;
                        Cash = false;
                    }
                }, (_) =>
                {
                    return BasketGoods.Count() > 0;
                });
            }
        }
        public BasketVM()
        {
            CurrentOrder = new Order();
            BasketGoods = new ObservableCollection<BasketGood>(GlobalResources.Context.BasketGoods.AsNoTracking().Where(g => g.UserId == GlobalResources.CurrentUser.Id).Include(g => g.User).Include(g => g.Good));
            if (BasketGoods.Count > 0)
            {
                foreach (var good in BasketGoods)
                {
                    CurrentOrder.TotalCost += good.TotalCost;
                }
            }
            Messenger.Default.Register<Good>(this, "add to basket", good =>
            {
                if (!GlobalResources.Context.BasketGoods.Where(bg => (bg.UserId == GlobalResources.CurrentUser.Id && bg.GoodId == good.Id)).Any())
                {
                    BasketGood NewBasketGood = new BasketGood(good);
                    BasketGoods.Add(NewBasketGood);
                    GlobalResources.Context.BasketGoods.Add(NewBasketGood);
                    GlobalResources.Context.SaveChanges();
                    CurrentOrder.TotalCost += NewBasketGood.TotalCost;
                    BasketGoods = new ObservableCollection<BasketGood>(GlobalResources.Context.BasketGoods.AsNoTracking().Where(g => g.UserId == GlobalResources.CurrentUser.Id).Include(g => g.User).Include(g => g.Good));
                }
                else
                {
                    MessageBox.Show("Товар уже находится в вашей корзине!");
                }
            });
        }
    }
}

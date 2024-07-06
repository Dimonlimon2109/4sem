using GalaSoft.MvvmLight;

namespace Sports_store.Models
{
    public class BasketGood : ViewModelBase
    {
        public Guid Id { get; set; }

        public Guid GoodId { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public Good Good { get; set; }

        private int amount;

        public int Amount { get => amount; set { amount = value; RaisePropertyChanged(nameof(Amount)); } }

        private decimal totalCost;

        public decimal TotalCost { get => totalCost; set { totalCost = value; RaisePropertyChanged(nameof(TotalCost)); } }

        public override string ToString()
        {
            return $"{this.Good.ToString()}, количество: {this.Amount}, общая стоимость: {this.TotalCost}";
        }
        public BasketGood(Good good)
        {
            Good = GlobalResources.Context.Goods.Find(good.Id);
            GoodId = good.Id;
            UserId = GlobalResources.CurrentUser.Id;
            User = GlobalResources.Context.Users.Find(GlobalResources.CurrentUser.Id);
            Amount = 1;
            TotalCost = Good.Cost;
        }

        public BasketGood()
        {
            Amount = 0;
            TotalCost = 0;
        }
    }
}

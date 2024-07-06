using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace Sports_store.Models
{
    public class Order : ViewModelBase
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        private User user;

        public User User { get { return user; } set { user = value; RaisePropertyChanged(nameof(User)); } }
        public string OrderGoods { get; set; }

        private decimal totalCost;

        public decimal TotalCost { get => totalCost; set { totalCost = value; RaisePropertyChanged(nameof(TotalCost)); } }

        public string Adress { get; set; }

        public string PayMethod { get; set; }
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public Order()
        {
            UserId = GlobalResources.CurrentUser.Id;
            this.User = GlobalResources.CurrentUser;
            OrderGoods = "";
            TotalCost = 0;
            Adress = "г. ул. д. ";
            Description = "";
        }

        public void BasketToString(ObservableCollection<BasketGood> basketGoods)
        {
            int goodNumber = 1;
            foreach (BasketGood basketGood in basketGoods)
            {
                if (basketGoods.Count > 1)
                {
                    this.OrderGoods += $"Товар {goodNumber}: ";
                    goodNumber++;
                }
                this.OrderGoods += basketGood.ToString() + "\n";
            }
        }
    }
}

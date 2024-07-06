using GalaSoft.MvvmLight;
using System.IO;

namespace Sports_store.Models
{
    public class Good : ViewModelBase
    {
        public Guid Id { get; set; }
        public string Name { get => name; 
            set { name = value; RaisePropertyChanged(nameof(Name)); } }
        public decimal Cost { get => cost; 
            set { if (value < 0)
                    cost = 0;
        else
                    cost = value; RaisePropertyChanged(nameof(Cost)); } }
        public string Category { get => category; set { category = value; RaisePropertyChanged(nameof(Category)); } }
        public string Type { get => type; set { type = value; RaisePropertyChanged(nameof(Type)); } }
        public string Color { get => color; set { color = value; RaisePropertyChanged(nameof(Color)); } }
        public int StockQuantity { get => stockQuantity; set { if (value < 0)
                    stockQuantity = 0;
        else
                    stockQuantity = value; 
                RaisePropertyChanged(nameof(StockQuantity)); } }
        public int SaledAmount { get => saledAmount; set { saledAmount = value; RaisePropertyChanged(nameof(SaledAmount)); } }
        public string Description { get => description; set { description = value; RaisePropertyChanged(nameof(Description)); } }
        public byte[] Image { get => image; set { image = value; RaisePropertyChanged(nameof(Image)); } }
        public decimal Rating { get => rating; set { rating = value; RaisePropertyChanged(nameof(Rating)); } }

        private ICollection<Review> reviews;
        public ICollection<Review> Reviews { get => reviews; set { reviews = value; RaisePropertyChanged(nameof(Reviews)); } }

        public ICollection<BasketGood> BasketGoods { get; set; }

        private string name;
        private decimal cost;
        private string category;
        private string type;
        private decimal rating;
        private byte[] image;
        private string color;
        private int stockQuantity;
        private int saledAmount;
        private string description;

        public override string ToString()
        {
            return $"{this.Name}, цена: {this.Cost} руб., {this.Category}, {this.Type}, " +
                $"{this.Color}";
        }

        public Good()
        {
            Name = "Название";
            Cost = 0;
            Category = GlobalResources.Categories[0];
            Type = GlobalResources.Types[0];
            Color = GlobalResources.Colors[0];
            StockQuantity = 1;
            SaledAmount = 0;
            Image = null;
            Description = "Описание";
        }

        public Good(Good good)
        {
            Id = good.Id;
            Name = good.Name;
            Cost = good.Cost;
            Category = good.Category;
            Type = good.Type;
            Color = good.Color;
            StockQuantity = good.StockQuantity;
            SaledAmount = good.SaledAmount;
            Image = good.Image;
            Description = good.Description;
        }
    }
}
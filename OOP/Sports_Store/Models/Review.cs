using GalaSoft.MvvmLight;

namespace Sports_store.Models
{
    public class Review : ViewModelBase
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }


        public User User { get; set; }

        public Guid GoodId { get; set; }

        public Good Good { get; set; }



        private DateOnly date;
        private decimal rating;
        private string description;

        public DateOnly Date { get => date; set { date = value; RaisePropertyChanged(nameof(Date)); } }
        public decimal Rating { get => rating; set { rating = value; RaisePropertyChanged(nameof(Rating)); } }
        public string Description { get => description; set { description = value; RaisePropertyChanged(nameof(Description)); } }

        public Review()
        {
            Date = new DateOnly();
            Rating = 0;
            Description = string.Empty;
        }
    }
}
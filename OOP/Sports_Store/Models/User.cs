using GalaSoft.MvvmLight;
using System.IO;

namespace Sports_store.Models
{
    public class User : ViewModelBase
    {
        public Guid Id { get; set; }
        private string login;
        private string password;
        private string? name;
        private string? surname;
        private string phoneNumber;
        private string email;
        private byte[]? image;
        private string? description;
        private byte isAdmin = 0;

        public User()
        {
            login = string.Empty;
            password = string.Empty;
            name = null;
            surname = null;
            phoneNumber = string.Empty;
            email = string.Empty;
            image = null;
            description = null;
        }

        public string Login
        {
            get => login;
            set
            {
                login = value;
                RaisePropertyChanged("Login");
            }
        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
                RaisePropertyChanged("Password");
            }
        }
        public string? Name
        {
            get => name;
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }
        public string? Surname
        {
            get => surname;
            set
            {
                surname = value;
                RaisePropertyChanged("Surname");
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                phoneNumber = value;
                RaisePropertyChanged("PhoneNumber");
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
                RaisePropertyChanged("Email");
            }
        }
        public byte[]? Image
        {
            get => image;
            set
            {
                image = value;
                RaisePropertyChanged("Image");
            }
        }
        public string? Description
        {
            get => description;
            set
            {
                description = value;
                RaisePropertyChanged("Description");
            }
        }

        public byte IsAdmin
        {
            get => isAdmin;
            set { isAdmin = value; RaisePropertyChanged("IsAdmin"); }
        }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<BasketGood> BasketGoods { get; set; }
    }
}

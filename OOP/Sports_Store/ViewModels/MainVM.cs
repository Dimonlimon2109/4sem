using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Sports_store.Command;
using Sports_store.Models;
using Sports_store.Views.MainView;
using System.Windows;
using System.Windows.Controls;

namespace Sports_store.ViewModels
{

    public enum Pages
    {
        Catalog,
        GoodPage,
        Profile,
        Basket
    }
    public class MainVM : ViewModelBase
    {

        private User currentUser;

        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                RaisePropertyChanged(nameof(currentUser));
            }
        }

        public UserControl[] UserControls = new UserControl[]
{
            new Catalog(),
            new GoodPage(),
            new Profile(),
            new Basket()
};

        private MyCommand changePage;

        public MyCommand ChangePage
        {
            get
            {
                return changePage ??= new MyCommand((obj) =>
                {
                    string str = (string)obj;
                    CurrentUserControl = UserControls[(int)(Pages)Enum.Parse(typeof(Pages), str)];
                    Messenger.Default.Send<string>(str);
                    if(str == "Catalog")
                    {
                        Messenger.Default.Send(str, "NoUpdate");
                    }
                });
            }
        }


        private UserControl currentUserControl;

        public UserControl CurrentUserControl
        {
            get { return currentUserControl; }
            set
            {
                currentUserControl = value;
                RaisePropertyChanged(nameof(currentUserControl));
            }
        }

        private MyCommand addNewGood;

        public MyCommand AddNewGood
        {
            get
            {
                return addNewGood ??= new MyCommand((obj) =>
                {

                    Messenger.Default.Send<Pages>(Pages.GoodPage);
                    Messenger.Default.Send<Good>(new Good(), "CreateNew");
                });
            }
        }
        public MainVM()
        {
            CurrentUserControl = UserControls[(int)Pages.Catalog];
            Messenger.Default.Register<Pages>(this, (page) =>
            {
                CurrentUserControl = UserControls[(int)page];
            });
            CurrentUser = GlobalResources.CurrentUser;
        }

        private MyCommand exit;

        public MyCommand Exit
        {
            get
            {
                return exit ??= new MyCommand((obj) =>
                {
                    Application.Current.Shutdown();
                });

            }
        }
        private MyCommand hide;

        public MyCommand Hide
        {
            get
            {
                return hide ??= new MyCommand((obj) =>
                {
                    Application.Current.Windows[0].WindowState = WindowState.Minimized;
                });

            }
        }
    }
}

using System.Configuration;
using System.Data;
using System.Windows;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Lab4
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static List<CultureInfo> _languages = new List<CultureInfo>();

        public static List<CultureInfo> Languages { get => _languages; }

        public static event EventHandler LanguageChanged;

        public static CultureInfo Language
        {
            get
            {
                return System.Threading.Thread.CurrentThread.CurrentUICulture;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("value");
                }
                if (value == System.Threading.Thread.CurrentThread.CurrentUICulture)
                {
                    return;
                }
                System.Threading.Thread.CurrentThread.CurrentUICulture = value;
                ResourceDictionary dict = new ResourceDictionary();
                switch (value.Name)
                {
                    case "ru-RU":
                        dict.Source = new Uri("D:\\study\\4_sem\\OOP\\Lab4\\ResourceDictionaries\\lang.ru-RU.xaml");
                        break;
                    default:
                        dict.Source = new Uri("D:\\study\\4_sem\\OOP\\Lab4\\ResourceDictionaries\\lang.xaml");
                        break;
                }
                ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
                                              where d.Source != null && d.Source.OriginalString.StartsWith("D:\\study\\4_sem\\OOP\\Lab4\\ResourceDictionaries\\lang.")
                                              select d).First();
                if (oldDict != null)
                {
                    int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                    Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                    Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
                }
                else
                {
                    Application.Current.Resources.MergedDictionaries.Add(dict);
                }
            }
        }
        public App()
        {
            _languages.Clear();
            _languages.Add(new CultureInfo("en-US"));
            _languages.Add(new CultureInfo("ru-RU"));
        }
    }

}

using Lab4.Models;
using Lab4.ViewModels;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ComboBox catBox;
        public static ComboBox colBox;
        public MainWindow()
        {
            InitializeComponent();
            Cursor = new Cursor(Application.GetResourceStream(new Uri("pack://application:,,,/Resources/normal.cur")).Stream);
            Mouse.OverrideCursor = Cursor;
            CatBox.ItemsSource = new List<string>()
            {
                "Все",
                "Обувь",
                "Куртка",
                "Штаны",
                "Шорты",
                "Футболка",
                "Футбол",
                "Бокс",
                "Баскетбол"
            };
            CatBox.SelectedIndex = 0;
            catBox = CatBox;
            ColBox.ItemsSource = new List<string>()
            {
                "Все",
                "Черный",
                "Белый",
                "Серый",
                "Оранжевый",
                "Красный",
                "Зеленый",
                "Синий"
            };
            ColBox.SelectedIndex = 0;
            colBox = ColBox;
            App.Language = new CultureInfo("ru-RU");
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Good>));
            using (FileStream fs = new FileStream("data.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, CatalogVM.GoodsFirst);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
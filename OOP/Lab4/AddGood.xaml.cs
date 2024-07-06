using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4
{
    /// <summary>
    /// Логика взаимодействия для AddGood.xaml
    /// </summary>
    public partial class AddGood : UserControl
    {
        public static ComboBox comboBox;
        public static ComboBox colorBox;
        public AddGood()
        {
            InitializeComponent();
            if (App.Language.Name == "ru-RU")
            {
                Combo.ItemsSource = new List<string>()
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
                Combo.SelectedIndex = 0;
                comboBox = Combo;
                Color.ItemsSource = new List<string>()
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
                Color.SelectedIndex = 0;
                colorBox = Color;
            }
            else
            {
                Combo.ItemsSource = new List<string>()
                {
                "All",
                "Shoes",
                "Jacket",
                "Trousers",
                "Shorts",
                "T-shirt",
                "Football",
                "Boxing",
                "Basketball"
                };
                Combo.SelectedIndex = 0;
                comboBox = Combo;
                Color.ItemsSource = new List<string>()
                {
                    "Black",
                    "White",
                    "Gray",
                    "Orange",
                    "Red",
                    "Green",
                    "Blue"
                };
                Color.SelectedIndex = 0;
                colorBox = Color;
            }
        }
    }
}

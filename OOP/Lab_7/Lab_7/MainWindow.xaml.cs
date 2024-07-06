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

namespace Lab_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
            textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n\n";
        }

        private void Control_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            textBlock2.Text = textBlock2.Text + "sender: " + sender.ToString() + "\n";
            textBlock2.Text = textBlock2.Text + "source: " + e.Source.ToString() + "\n\n";
        }

        private void Control_MouseDown3(object sender, MouseEventArgs e)
        {
            textBlock3.Text = textBlock3.Text + "sender: " + sender.ToString() + "\n";
            textBlock3.Text = textBlock3.Text + "source: " + e.Source.ToString() + "\n\n";
        }

        private void SayHelloCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }

    public static class CustomCommands
    {
        public static readonly RoutedUICommand SayHelloCommand = new RoutedUICommand("Say Hello", "SayHello", typeof(CustomCommands));
    }
}

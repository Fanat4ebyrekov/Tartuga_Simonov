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
using Tartuga_Simonov.EF;
using Tartuga_Simonov.Pages;
using Tartuga_Simonov.Windows;
using static Tartuga_Simonov.Clases.ListDish;

namespace Tartuga_Simonov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CornerRadius CornerRadius { get; set; }
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Bakery_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Bakery());
        }

        private void Berevage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Beverage());
        }

        private void Salad_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Salad());
        }

        private void FastFood_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FastFood());
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
            OrderWindow orders = new OrderWindow();
            orders.ShowDialog();
            this.Close();

            MessageBox.Show(dishes.Count.ToString());


        }
    }
}

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
using System.Windows.Shapes;
using Tartuga_Simonov.EF;
using static Tartuga_Simonov.Clases.Entity;
using Tartuga_Simonov.Clases;
using static Tartuga_Simonov.Clases.ListDish;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tartuga_Simonov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {

        public static decimal FinalCost;
        
        public OrderWindow()
        {
            InitializeComponent();
           
            lvOrder.ItemsSource = ListDish.dishes.ToList();
            //tbCost.Text = FinalCost.ToString();
            //tbCost.Text = Clases.SumWithDiscount.Sum(_date, FinalCost).ToString();
            DateTime dateTime = DateTime.Now;
            tbCost.Text = Clases.SumWithDiscount.Sum(dateTime, OrderWindow.FinalCost).ToString();
            GetProductList();

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void GetProductList()
        {
            lvOrder.ItemsSource = ListDish.dishes;
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

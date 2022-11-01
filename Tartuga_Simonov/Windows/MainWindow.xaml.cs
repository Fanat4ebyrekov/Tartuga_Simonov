using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Tartuga_Simonov.Clases;
using Tartuga_Simonov.EF;
using Tartuga_Simonov.Pages;
using Tartuga_Simonov.Windows;
using static Tartuga_Simonov.Clases.ListDish;

namespace Tartuga_Simonov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, MenuInterface, INotifyPropertyChanged
    {
        public CornerRadius CornerRadius { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Bakery(this);
            tbQty.Text = dishes.Count.ToString();
        }

        private void Bakery_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Bakery(this);
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

            


        }

        private int countDishes;

        public int COuntDishes
        {
            get { return countDishes; }
            set { countDishes = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void ChangeDishCount(int count)
        {
            tbQty.Text = count.ToString();
        }


    }
}

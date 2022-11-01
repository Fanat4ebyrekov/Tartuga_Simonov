using System;
using System.Collections.Generic;
using System.IO;
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
using static Tartuga_Simonov.Clases.Entity;
using System.Collections;
using System.Drawing;
using Tartuga_Simonov.Windows;
using static Tartuga_Simonov.Clases.ListDish;
using Tartuga_Simonov.Clases;

namespace Tartuga_Simonov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Bakery.xaml
    /// </summary>
    public partial class Bakery : Page
    {
        
        public Bakery()
        {

            InitializeComponent();
            BakeryMenu.ItemsSource = context.Dish.Where(i => i.IdCategory == 1).ToList();
                        
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            var button = sender as Button;
            if (button == null)
                return;
            var dishes = button.DataContext as Dish;

            ListDish.dishes.Add(dishes);


        }



    }      
}


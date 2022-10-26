﻿using System;
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
using static Tartuga_Simonov.Clases.Entity;
using Tartuga_Simonov.Windows;

namespace Tartuga_Simonov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Beverage.xaml
    /// </summary>
    public partial class Beverage : Page
    {

        
        
        public Beverage()
        {
            InitializeComponent();

            Beverage.ItemsSource = context.Beverage.ToList();

            BeverageMenu.ItemsSource = context.Beverage.ToList();
        }

        private void BeverageMenu_KeyUp(object sender, KeyEventArgs e)
        {
            var resClick = MessageBox.Show($"Добавить заказ {(BeverageMenu.SelectedItem as EF.Beverage).Title}", "Подтвержение", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (resClick == MessageBoxResult.Yes)
            {
                var button = sender as Button;

                if (button == null)
                    return;

                var dish = button.DataContext as Dish;

                addOrder.ShowDialog();


            }
        }
    }
}

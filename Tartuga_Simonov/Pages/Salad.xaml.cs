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
    /// Логика взаимодействия для Salad.xaml
    /// </summary>
    public partial class Salad : Page
    {
        private MenuInterface menuInteface;
        public Salad(MenuInterface menuInterface)
        {

            InitializeComponent();
            this.menuInteface = menuInterface;
            SaladMenu.ItemsSource = context.Dish.Where(i => i.IdCategory == 1).ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var btnAddToCart = sender as Button;

            if (btnAddToCart == null)
                return;
            var dishes = btnAddToCart.DataContext as Dish;

            if (dishes == null)
                return;

            foreach (var item in ListDish.dishes)
            {
                if (item == dishes)
                {
                    item.Qty++;

                    OrderWindow.FinalCost += dishes.Cost;
                    return;
                }
            }

            ListDish.dishes.Add(dishes);
            menuInteface.ChangeDishCount(ListDish.dishes.Count);
        }
    }
}

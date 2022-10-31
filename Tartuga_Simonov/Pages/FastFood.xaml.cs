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
using static Tartuga_Simonov.Clases.Entity;
using Tartuga_Simonov.Windows;

namespace Tartuga_Simonov.Pages
{
    /// <summary>
    /// Логика взаимодействия для FastFood.xaml
    /// </summary>
    public partial class FastFood : Page
    {
        public FastFood()
        {
            InitializeComponent();

            FastFoodMenu.ItemsSource = context.Dish.ToList();
        }

        private void FastFoodMenu_KeyUp(object sender, KeyEventArgs e)
        {
            var resClick = MessageBox.Show($"Добавить заказ {(FastFoodMenu.SelectedItem as EF.Dish).Title}", "Подтвержение", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (resClick == MessageBoxResult.Yes)
            {
                Dish userEdit = FastFoodMenu.SelectedItem as Dish;


                OrderWindow addOrder = new OrderWindow();

                addOrder.ShowDialog();


            }
        }
    }
}

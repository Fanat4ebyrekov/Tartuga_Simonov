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
    /// Логика взаимодействия для Salad.xaml
    /// </summary>
    public partial class Salad : Page
    {
        public Salad()
        {
            InitializeComponent();

            SaladMenu.ItemsSource = context.Dish.ToList();
        }

        private void SaladMenu_KeyUp(object sender, KeyEventArgs e)
        {
            var resClick = MessageBox.Show($"Добавить заказ {(SaladMenu.SelectedItem as EF.Dish).Title}", "Подтвержение", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (resClick == MessageBoxResult.Yes)
            {

                OrderWindow addOrder = new OrderWindow();

                addOrder.ShowDialog();


            }
        }
    }
}

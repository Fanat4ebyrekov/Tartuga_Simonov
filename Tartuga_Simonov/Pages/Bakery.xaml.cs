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

namespace Tartuga_Simonov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Bakery.xaml
    /// </summary>
    public partial class Bakery : Page
    {
        //Bakery bakery = new Bakery();
        bool isAdd = true;
        List<EF.Bakery> listEmployee = new List<EF.Bakery>();
        public Bakery()
        {
            InitializeComponent();
            BakeryMenu.ItemsSource = context.Bakery.ToList();
            isAdd = false;
            
        }

        //private void Filter()
        //{
        //    listEmployee = context.Bakery.ToList();
        //    listEmployee = listEmployee.Where(e => e.Title.Contains(tbTitle.Text) || e.Cost.Contains(tbCost.Text).ToList());


        //    BakeryMenu.ItemsSource = listEmployee;
        //}

        private void BakeryMenu_KeyUp(object sender, KeyEventArgs e)
        {
            var resClick = MessageBox.Show($"Добавить заказ {(BakeryMenu.SelectedItem as EF.Bakery).Title}", "Подтвержение", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (resClick == MessageBoxResult.Yes)
            {
                EF.Bakery userEdit = BakeryMenu.SelectedItem as EF.Bakery;

                OrderWindow addOrder = new OrderWindow(userEdit);
                
                addOrder.ShowDialog();
                

            }
        }
    }      
}


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

namespace Tartuga_Simonov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        //Bakery bakery = new Bakery();
        //Beverage beverage = new Beverage();
        EF.Bakery OrderBakery = new EF.Bakery();
        bool isEdit = true;

        public OrderWindow()
        {
            InitializeComponent();
            isEdit = false;

        }

        public OrderWindow(EF.Bakery bakery)
        {
            InitializeComponent();
            NameBL.Text = bakery.Title;
            CostBL.Text = Convert.ToString(bakery.Cost);
            OrderBakery = bakery;
            isEdit = true;
        }
    }
}

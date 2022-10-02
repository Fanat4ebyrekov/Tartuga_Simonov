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
            BakeryMenu.ItemsSource = context.Bakery.ToList();

            
        }

    }
}

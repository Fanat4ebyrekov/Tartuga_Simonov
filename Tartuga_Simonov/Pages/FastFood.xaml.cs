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

            FastFoodMenu.ItemsSource = context.FastFood.ToList();
        }
    }
}

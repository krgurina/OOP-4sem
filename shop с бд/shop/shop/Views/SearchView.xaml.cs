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
using System.Collections.ObjectModel;
using shop.Database;
using shop.Models;
using shop.ViewModels;

namespace shop.Views
{
    /// <summary>
    /// Логика взаимодействия для SearchView.xaml
    /// </summary>
    public partial class SearchView : Page
    {

        

        public SearchView()
        {
            InitializeComponent();
            //SearchViewModel search = new SearchViewModel();


            //productList.ItemsSource = products;//.ToList();
            //productList.ItemsSource = ShopDbContext.db.PRODUCTS.ToList();
        }


    }
}

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
using System.Windows.Shapes;

namespace VideoGamesStore.Views
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        private Authorization auth;
        public Catalog(Authorization authorization)
        {
            InitializeComponent();
            auth = authorization;
        }
        private void BackToAuth(object sender, RoutedEventArgs e)
        {
            // проверка на открытия окна авторизации для избежания System.OperationException
            if (auth == null || !auth.IsVisible)
            {
                auth = new Authorization();
            }
            auth.Show();
            Close();
        }
    }
}

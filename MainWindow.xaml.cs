﻿using abaevapppps.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace abaevapppps
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrmMain.Navigate(new Pages.PageAuto());
            DbConnect.entObj = new ImpulsEntities();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrmMain.GoBack();
            }
            catch (Exception )
            {
                MessageBox.Show("Вы на начальной странице!");  
            }
            
        }


        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FrmMain.Navigate(new Pages.InfoPage());
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, сбой приложения!");
            }
        }
    }
}

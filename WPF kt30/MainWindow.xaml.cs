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

namespace WPF_kt30
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string pass = "1234";
        private string inputPass = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            inputPass = passwTxt.ToString();
            if (inputPass == pass)
            {
                txtDisplay.Text = "Welkom";
                passwTxt.Foreground = Brushes.Green;
            }
            else
            {
                MessageBox.Show("Ты кто?");
                passwTxt.Foreground = Brushes.Red;
            }
        }
    }
}

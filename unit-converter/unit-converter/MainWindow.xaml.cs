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

namespace unit_converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Converter lengthConverter;
        public MainWindow()
        {
            InitializeComponent();
            this.lengthConverter = new LengthConverter();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String fromType = lenComboFrom.Text;
            String toType = lenComboTo.Text;
            String fromStr = lenFrom.Text;
            double fromValue = double.Parse(fromStr);
            double result = lengthConverter.convert(fromType, toType, fromValue);
            lenTo.Text = result.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button2");
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button3");
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button4");
        }
    }
}

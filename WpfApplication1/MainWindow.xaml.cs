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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked == true)
            {
                MessageBox.Show("Ciao");
            }
            else
            {
                if (radioButton2.IsChecked == true)
                {
                    Class1 obj = new Class1("Cancaro");
                    obj.printStr();
                }
                else
                {
                    MessageBox.Show("Obbligatorio selezionare una scelta!");
                }
            }
        }
    }
}

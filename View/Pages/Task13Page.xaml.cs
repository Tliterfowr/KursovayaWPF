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

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task13Page.xaml
    /// </summary>
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer13_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int[] S = new int[] { 101101, 10100, 11001 };
                var str = string.Join(" ", S);
                MessageBox.Show(str, "Первоначальный массив:");

                Array.Sort(S);

                var str1 = string.Join(" ", S);
                MessageBox.Show(str1, "Упорядоченный массив:");

                double average = S.Average();
                var str2 = string.Join(" ", S);
                MessageBox.Show(str2, "Сумма чисел:");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

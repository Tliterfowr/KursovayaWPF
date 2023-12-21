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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int[] S = new int[15];
                for (int i = 0; i < S.Length; i++)
                {
                    S[i] = rnd.Next(10, 100);
                }
                var str = string.Join(" ", S);
                MessageBox.Show(str, "Первоначальный массив:");

                int[] S1 = new int[15];
                for (int i = 0; i < S.Length; i++)
                {
                    string nS = S[i].ToString();
                    string firstDigit = nS[0].ToString();
                    string secondDigit = nS[1].ToString();
                    S1[i] = int.Parse(secondDigit + firstDigit);
                }
                var str1 = string.Join(" ", S1);
                MessageBox.Show(str1, "Новая разрядность:");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}


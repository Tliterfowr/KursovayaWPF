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
    /// Логика взаимодействия для Task10Page.xaml
    /// </summary>
    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer10_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int[] S = new int[10];
                for (int i = 0; i < S.Length; i++)
                {
                    S[i] = rnd.Next(1, 10);
                }
                var str = string.Join(" ", S);
                MessageBox.Show(str, "Первоначальный массив:");

                for (int i = 0; i < S.Length; i++)
                {
                    for (int j = i + 1; j < S.Length; j++)
                    {
                        if (S[i] == S[j])
                        {
                            MessageBox.Show($"Повторяющиеся элементы найдены по координатам: {i} и {j}");
                            
                        }
                    }
                }
                //var str1 = string.Join(" ", S1);
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

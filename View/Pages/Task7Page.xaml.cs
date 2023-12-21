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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int[] S = new int[7];
                for (int i = 0; i < S.Length; i++)
                {
                    S[i] = rnd.Next(10, 100);
                }

                var str = string.Join(" ", S);
                MessageBox.Show(str, "Первоначальный массив:");



                int[] S1 = new int[7];
                for (int i = 0; i < S.Length; i++)
                {
                    S1[i] = S[i] / 10;
                }
                var str1 = string.Join(" ", S1);
                MessageBox.Show(str1, "Старшие разряды чисел:");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();
                double[] S = new double[7];
                for (int i = 0; i < S.Length; i++)
                {
                    S[i] = rnd.NextDouble();
                }

                var str = string.Join(" ", S);
                MessageBox.Show(str, "Массив из 7-ти элементов:");

                double[] S1 = new double[9];
                for (int i = 0; i < S1.Length; i++)
                {
                    S1[i] = rnd.NextDouble();
                }
                var str1 = string.Join(" ", S1);
                MessageBox.Show(str1, "Массив из 9-ти элементов:");



                double[] N = S.Concat(S1).OrderByDescending(num => num).ToArray();

                var str2 = string.Join(" ", N);
                MessageBox.Show(str2, "Сформированный массив:");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

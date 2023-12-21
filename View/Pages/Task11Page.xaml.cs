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
    /// Логика взаимодействия для Task11Page.xaml
    /// </summary>
    public partial class Task11Page : Page
    {
        public Task11Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer11_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int[] S = new int[] { 10000, 10100, 11001 };
                var str = string.Join(" ", S);
                MessageBox.Show(str, "Первоначальный массив:");

                int[] S1 = new int[S.Length];
                for (int i = 0; i < S.Length; i++)
                {
                    S1[i] = S[(i + 2 ) % S.Length];
                }

                var str1 = string.Join(" ", S1);
                MessageBox.Show(str1, "Сдвиг:");

                string B1 = string.Join("", S);
                string B2 = string.Join("", S1);
                long D = long.Parse(B1, System.Globalization.NumberStyles.HexNumber) - long.Parse(B2, System.Globalization.NumberStyles.HexNumber);

                var str2 = string.Join(" ", D);
                MessageBox.Show(str2, "Разность:");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

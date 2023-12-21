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
    /// Логика взаимодействия для Task14Page.xaml
    /// </summary>
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer14_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int[] S = new int[] { 101101, 10100, 11001 };
                var str = string.Join(" ", S);
                MessageBox.Show(str, "Первоначальный массив:");

                int max = S.Max();
                int min = S.Min();
                int max1 = Array.IndexOf(S, max);
                int min1 = Array.IndexOf(S, min);

                int temp = S[max1];
                S[max1] = S[min1];
                S[min1] = temp;

                var str1 = string.Join(" ", S);
                MessageBox.Show(str1, "Упорядоченный массив:");
 
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

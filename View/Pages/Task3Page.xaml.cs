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
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer3_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string S = "11111";
                var str = string.Join(" ", S);
                MessageBox.Show(str, "Число в двоичной системе:");

                string[] P = S.Split('.');
                string P1 = P[0];
                string P2 = P.Length > 1 ? P[1] : "";
                int D0 = Convert.ToInt32(P1, 2);
                double D1 = 0;
                for (int i = 0; i < P2.Length; i++)
                {
                    D1 += (P2[i] - '0') * Math.Pow(2, -(i + 1));
                }
                double D2 = D0 + D1;
                string N = Convert.ToString((int)D2, 8);
                var str1 = string.Join(" ", N);
                MessageBox.Show(str1, "Число в восьмеричной системе:");

            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

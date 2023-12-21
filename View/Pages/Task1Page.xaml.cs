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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string S =  "11111";
                var str = string.Join(" ", S);
                MessageBox.Show(str, "Число в двоичной системе:");

                int D = Convert.ToInt32(S, 2);

                string H = D.ToString("X");

                var str1 = string.Join(" ", H);
                MessageBox.Show(str1, "Число в шеснадцатеричной системе:");

            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

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
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int[] S = new int[9]; 
                for (int i = 0; i < S.Length; i++)
                {
                    S[i] = rnd.Next(0, 8) * 10 + rnd.Next(0, 8);
                }
              
                var str = string.Join(" ", S);
                MessageBox.Show(str, "Первоначальный массив:");



                int[] S1 = new int[9];
                for (int i = 0; i < S.Length; i++)
                {
                    S1[i] = Convert.ToInt32(S[i].ToString(), 8);
                }
                var str1 = string.Join(" ", S1);
                MessageBox.Show(str1, "Числа в десятичной системе:");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

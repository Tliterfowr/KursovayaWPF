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
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int[] S = new int[12];
                for (int i = 0; i < S.Length; i++)
                {
                    S[i] = rnd.Next(0, 2);
                }

                var str = string.Join(" ", S);
                MessageBox.Show(str, "Первоначальный массив:");

                Dictionary<int, int> C = new Dictionary<int, int>();
                foreach (int num in S)
                {
                    if (C.ContainsKey(num))
                    {
                        C[num]++;
                    }
                    else
                    {
                        C.Add(num, 1);
                    }
                }
                List<int> N = new List<int>();
                foreach (int num in S)
                {
                    if (C[num] <= 2)
                    {
                        N.Add(num);
                    }
                }
                int[] S1 = N.ToArray();

                var str1 = string.Join(" ", N);
                MessageBox.Show(str1, "Новый массив:");
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}

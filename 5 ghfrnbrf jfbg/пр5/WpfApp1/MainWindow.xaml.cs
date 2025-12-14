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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Пуск_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(varA.Text, out double a))
            {
                MessageBox.Show("Введите числовое значение");
                return;
            }
            if (!double.TryParse(varB.Text, out double b))
            {
                MessageBox.Show("Введите числовое значение");
                return;
            }
            if (!double.TryParse(varH.Text, out double h))
            {
                MessageBox.Show("Введите числовое значение");
                return;
            }
            if (b-a<h)
            {
                MessageBox.Show("Введены неккоректные значения");
                return;
            }
            double y;
            Tab.Items.Clear();
            Tab.Items.Add(String.Format("{0,10}{1,20}", "x", "y"));
            Tab.Items.Add("---------------------------------");
            double rezB = Math.Pow(Math.Log(b), 2) + b;
            for (double x = a; x < b; x += h)
            {
                y = Math.Pow(Math.Log(x), 2) + x;
                Tab.Items.Add($"{x,10:f}{y,20:f3}");
            }
            Tab.Items.Add($"{b,10:f}{rezB,20:f3}");
            double rezA = Math.Pow(Math.Log(a), 2) + a;
            double max = rezA;
            double min = rezA;
            for (double x = a; x < b; x += h)
            {
                double z = Math.Pow(Math.Log(x), 2) + x;
                if (z > rezA) max = z;
                if (z < rezA) min = z;
            }
            if (rezB > max) max = rezB;
            if (rezB < min) min = rezB;
            Tab.Items.Add($"Минимум функции равен {min}");
            Tab.Items.Add($"Максимум функции равен {max}");
        }
    }
}

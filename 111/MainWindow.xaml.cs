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

namespace _111
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

        private void firstClick(object sender, RoutedEventArgs e)
        {
            rez.Content = "";// Очистка текста
            double x = double.Parse(varX.Text); //Парсинг данных
            double y = double.Parse(varY.Text); //Парсинг данных
            rez.Content = ((5 * y) + (x - 5) / (x * y)).ToString(); //Вывод результатов в поле ответа
        }

        private void secondClik(object sender, RoutedEventArgs e)
        {
            rez.Content = "";
            double x = double.Parse(varXSecond.Text); //Парсинг данных
            double stepen = x - 1;
            double secondOperator = Math.Abs(x); //Модуль числа
            rez1.Content = Math.Pow(secondOperator, 1 / stepen).ToString(); //Вывод результатов в поле ответа
        }

        private void ThirdClik(object sender, RoutedEventArgs e)
        {
            rez.Content = "";
            double x = double.Parse(varXThird.Text); //Парсинг данных
            double first = (2 * x) - 1;
            double second = Math.Pow(first, 7);
            double third = Math.Pow(Math.Tan(second), 3);

            rez2.Content = third.ToString();
        }

        private void fourthClick(object sender, RoutedEventArgs e)
        {
            rez.Content = ""; //очищение вывода
            int x = int.Parse(varX1.Text); //Парсинг данных
            int y = int.Parse(varY1.Text); //Парсинг данных
            bool first = (x >= -13 && x <= -2) && (y >= 7 && y <= 11); //координата попадает в указанный диапазон
            bool second = (x >= -10 && x <= -5) && (y >= 4 && y <= 7); //координата попадает в указанный диапазон
            rez3.Content = (first || second).ToString();
        }
    }
}

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

namespace PogodThem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // Получаем текущее время
            DateTime currentTime = DateTime.Now;

            // Определяем текущее время дня
            if (currentTime.Hour >= 0 && currentTime.Hour <= 2)
            {
                // Устанавливаем темную тему для ночного времени
                ubl.Background = new SolidColorBrush(Colors.Black);
            }
            else if (currentTime.Hour >= 4 && currentTime.Hour <= 11)
            {
                // Устанавливаем светлую тему для утреннего времени
                ubl.Background = new SolidColorBrush(Colors.LightGray);
            }
            else if (currentTime.Hour >= 17 && currentTime.Hour <= 23)
            {
                // Устанавливаем яркую тему для дневного времени
                ubl.Background = new SolidColorBrush(Colors.LightBlue);
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour <= 16)
            {
                // Устанавливаем сумеречную тему для вечернего времени
                ubl.Background = new SolidColorBrush(Colors.Red);
            }

        }
    }
}

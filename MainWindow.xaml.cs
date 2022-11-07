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

namespace Prakt9
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

        private void Записать(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(House.Text, out int house); Int32.TryParse(Kvart.Text, out int kvart);
            if (house >= 0 && kvart >= 0)
            {
                Puple people = new Puple(lastName.Text, Street.Text, house, kvart);
                dataGrid.Items.Add(people);
            }
        }

        private void Найти(object sender, RoutedEventArgs e)
        {
            int kol = 0;
            foreach (Puple people in dataGrid.Items)
            {
                if (people.Street == StreetSearch.Text)
                {
                    kol++;
                }
            }
            MessageBox.Show($"Количество учеников на улице {StreetSearch.Text} = {kol}");
        }

        private void Spravka(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калитин Сергей.ИСП-31.\nЗадание:\nОписать, используя структуру, данные на учеников (фамилия, улица, дом, квартира)." +
                "Вывести результат на экран. Вывести информацию, сколько учеников живет на заданной улице. ");
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

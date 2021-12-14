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

namespace MainApp5
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

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Triad (тройка нечетных чисел). Создать необходимые методы и свойства. Определить метод сравнения двух триад на равенство. Создать перегруженный метод сравнения трех триад на равенство");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {           

            Triad Pervay = new Triad(); //инициализация первой триады

            Pervay.First = Convert.ToInt32(OneOne.Text);
            Pervay.Second = Convert.ToInt32(OneTwo.Text);
            Pervay.Third = Convert.ToInt32(OneThree.Text);

            Triad Vtoray = new Triad(); //инициализация второй триады

            Vtoray.First = Convert.ToInt32(TwoOne.Text);
            Vtoray.Second = Convert.ToInt32(TwoTwo.Text);
            Vtoray.Third = Convert.ToInt32(TwoThree.Text);

            bool rez;
            rez = Triad.Compare(Pervay.First, Pervay.Second, Pervay.Third, Vtoray.First, Vtoray.Second, Vtoray.Third);

            if (rez == true)
            {
                MessageBox.Show("Триады равны!");
            }
            else
            {
                MessageBox.Show("Триады отличаются!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Triad Pervay = new Triad(); //инициализация первой триады

            Pervay.First = Convert.ToInt32(OneOne.Text);
            Pervay.Second = Convert.ToInt32(OneTwo.Text);
            Pervay.Third = Convert.ToInt32(OneThree.Text);

            Triad Vtoray = new Triad(); //инициализация второй триады

            Vtoray.First = Convert.ToInt32(TwoOne.Text);
            Vtoray.Second = Convert.ToInt32(TwoTwo.Text);
            Vtoray.Third = Convert.ToInt32(TwoThree.Text);

            Triad Thretey = new Triad(); //инициализация третьей триады

            Thretey.First = Convert.ToInt32(ThreeOne.Text);
            Thretey.Second = Convert.ToInt32(ThreeTwo.Text);
            Thretey.Third = Convert.ToInt32(ThreeThree.Text);

            bool rezf, rezl;
            Triad.Compare(Pervay.First, Pervay.Second, Pervay.Third, Vtoray.First, Vtoray.Second, Vtoray.Third, Thretey.First, Thretey.Second, Thretey.Third, out rezf, out rezl);

            if (rezf == true && rezl == true)
            {
                MessageBox.Show("Все триады равны!");
            }
            

            if (rezf == true && rezl == false)
            {
                MessageBox.Show("Вторая и треться триады не равны!");
            }

            if (rezf == false && rezl == true)
            {
                MessageBox.Show("Первая и третья триады не равны!");
            }

            if (rezf == false && rezl == false)
            {
                MessageBox.Show("Все триады не равны");
            }
        }
    }
}

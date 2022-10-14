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

namespace lab5_team
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

        #region Меню
        //Кнопка "Информация"
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лабораторная работа №5 по МДК 02.02" +
                "\nВыполнили студенты группы ИСП-41 Константинов Кирилл и Бандуркин Дмитрий" +
                "\nВариант задания - 13" +
                "\nДаны два двумерных массива вещественных элементов. Размер исходных массивов не превосходит 10х10 элементов." +
                "\nПреобразовать все нечетные строки каждого массива так, чтобы элементы составляли возрастающую по абсолютной величине последовательность." +
                "\nВывести преобразованные массивы. Упорядочивание элементов оформить в виде процедуры с передачей в нее всех необходимых элементов.", "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //Кнопка "Очистить таблицы"
        private void ClearTables_Click(object sender, RoutedEventArgs e)
        {
            Table_One.ItemsSource = null;
            Table_Two.ItemsSource = null;
            Table1_N.Text = null;
            Table1_M.Text = null;
            Table2_N.Text = null;
            Table2_M.Text = null;
        }

        //Кнопка "Выход"
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion

        #region Работа с таблицей 1
        private void FillArrayTable1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(Table1_N.Text);
                int m = Convert.ToInt32(Table1_M.Text);
                if (n <= 10 && m <= 10)
                {
                    Random rnd = new Random();
                    double[,] matr = new double[n, m];
                    for(int i = 0; i < matr.GetLength(0); i++)
                    {
                        for(int j = 0; j < matr.GetLength(1); j++)
                        {
                            matr[i, j] = rnd.Next(-5,5) ;
                        }
                    }
                    Table_One.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
                }
                else MessageBox.Show("Размеры массива не могут превышать значений больше 10", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TaskTable1_Click(object sender, RoutedEventArgs e)
        {
        }
        #endregion

        #region Работа с таблицей 2
        private void FillArrayTable2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(Table2_N.Text);
                int m = Convert.ToInt32(Table2_M.Text);
                if (n <= 10 && m <= 10)
                {
                    Random rnd = new Random();
                    double[,] matr = new double[n, m];
                    for (int i = 0; i < matr.GetLength(0); i++)
                    {
                        for (int j = 0; j < matr.GetLength(1); j++)
                        {
                            matr[i, j] = rnd.Next(-5, 5);
                        }
                    }
                    Table_Two.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
                }
                else MessageBox.Show("Размеры массива не могут превышать значений больше 10", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TaskTable2_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}

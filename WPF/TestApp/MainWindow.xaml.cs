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

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static FactorClass factorC = new FactorClass();
        public MainWindow()
        {
            InitializeComponent();
            mainGrid.DataContext = factorC;
        }

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{factorC.FactorTest}");
        }

        private void increaseBtn_Click(object sender, RoutedEventArgs e)
        {
            factorC.FactorTest *= 2;
        }
    }
}

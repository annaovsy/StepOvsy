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
            var points = new Point[4]
            {
                new Point(10,20),
                new Point(15,25),
                new Point(20,30),
                new Point(1,7)
            };
            factorC.PointsTransform = points;
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

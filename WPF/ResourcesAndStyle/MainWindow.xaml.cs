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

namespace ResourcesAndStyle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Phone testPhone;
        public MainWindow()
        {
            InitializeComponent();
            testPhone = new Phone
            {
                Company = "Google",
                Title = "Samsung",
                Price = 35000
            };
            mainGrid.DataContext = testPhone;
        }

        private void ButtonChangePrice(object sender, RoutedEventArgs e)
        {
            testPhone.Price += 1000;
        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Название: {testPhone.Title} Цена: {testPhone.Price}");
        }
    }
}

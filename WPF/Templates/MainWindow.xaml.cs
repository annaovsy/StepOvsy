using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Templates
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> phones;
        public ObservableCollection<Phone> Phones { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            //phones = new ObservableCollection<string> { "123", "dfgdfg", "***" };
            Phones = new ObservableCollection<Phone>
            {
               new Phone
               {
                   Id = 1,
                   ImagePath = "iphone-12-mini-blue-select-2020",
                   Company = "Apple",
                   Title = "iPhone"
               },
               new Phone
               {
                   Id = 2,
                   ImagePath = "",
                   Company = "Samsung",
                   Title = "Galaxy"
               },
               new Phone
               {
                   Id = 3,
                   ImagePath = "",
                   Company = "Sony",
                   Title = "G45"
               },
            };       
            
            phoneLists.ItemsSource = Phones;
        }

        private void myBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пример");
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            //string phone = phoneTexBox.Text;
            //phones.Add(phone);
            var phone = new Phone
            {
                Company = "Google",
                Id = 4,
                ImagePath = "",
                Title = "Honor"
            };
            Phones.Add(phone);
        }

        private void phoneLists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone p = (Phone)phoneLists.SelectedItem;
            MessageBox.Show(p.Title);
        }
    }
}

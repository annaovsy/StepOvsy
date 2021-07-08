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

namespace Registration
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person;
        public MainWindow()
        {
            InitializeComponent();
            person = new Person();
            mainStackPanel.DataContext = person;
        }

        private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Username: {person.Username} " +
                $"Password: {person.Password} " +
                $"Email: {person.Email} " +
                $"ConfirmEmail: {person.ConfirmEmail} " +
                $"Birthday: {person.Birthday}");
        }
    }
}

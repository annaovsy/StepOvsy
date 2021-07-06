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
using System.Data;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Num { get; set; } 
        public string Result { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement element in MainGrid.Children)
            {
                if(element is Button)
                {
                    ((Button)element).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Num = (string)((Button)e.OriginalSource).Content;
            if (Num == "C")
            {
                TextFirst.Text = "";
            }
            else if (Num == "CE") 
            {
                TextFirst.Text = "";
                TextSecond.Text = "";
            }
            else if (Num == "<")
            {
                if (TextFirst.Text.Length != 0)
                {
                    TextFirst.Text = TextFirst.Text.Remove(TextFirst.Text.Length - 1);
                }
            }
            else if (Num == "=")
            {
                TextSecond.Text = TextFirst.Text + "=";
                Result = new DataTable().Compute(TextFirst.Text, null).ToString();
                TextFirst.Text = Result;
            }
            else
            {
                TextFirst.Text += Num;
            }
         

           
        }
    }
}

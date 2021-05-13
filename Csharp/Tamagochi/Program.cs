using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //в проект добавили ссылку

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            if(MessageBox.Show("привет", "Сообщение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Console.WriteLine("нажали ок");
            }
            else
            {
                Console.WriteLine("нажали Cencel");
            }
            int n = 100;
            //MessageBox.Show($"n = {n}");

        }
    }
}

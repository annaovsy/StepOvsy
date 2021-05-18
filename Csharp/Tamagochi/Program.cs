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
            Random rand = new Random();
            Personage personage = new Personage();
            int count = 0;
            do
            {
                switch (rand.Next(1, 5))
                {
                    case 1:
                        if (MessageBox.Show("Кушать", "Я хочу", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            personage.Feed();
                            count = 0;
                        }
                        else
                        {
                            personage.Sick();
                            count++;
                        }
                        break;
                    case 2:
                        if (MessageBox.Show("Гулять", "Я хочу", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            personage.Walk();
                            count = 0;
                        }
                        else
                        {
                            personage.Sick();
                            count++;
                        }
                        break;
                    case 3:
                        if (MessageBox.Show("Лечиться", "Я хочу", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            personage.Heal();
                            count = 0;
                        }
                        else
                        {
                            personage.Sick();
                            count++;
                        }
                        break;
                    case 4:
                        if (MessageBox.Show("Играть", "Я хочу", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            personage.Play();
                            count = 0;
                        }
                        else
                        {
                            personage.Sick();
                            count++;
                        }
                        break;
                    case 5:
                        if (MessageBox.Show("Спать", "Я хочу", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            personage.Sleep();
                            count = 0;
                        }
                        else
                        {
                            personage.Sick();
                            count++;
                        }
                        break;
                }
            } while (count != 3);
            
            MessageBox.Show("Умер", "Я", MessageBoxButtons.OK);
            personage.Die();
        }
    }
}

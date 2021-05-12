using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tamagotchi
{
    class Personage
    {
        Random rand = new Random();
        public string Feed()
        {
            Console.Clear();
            string paint = @" 
              ┌───────────┐
              │ ┌─┐   ┌─┐ │
              │ └─┘   └─┘ │
            ▓▓│   ┌───┐   │▓▓
            ▓▓│   │   │   │▓▓
              │   └───┘   │
              └───────────┘";
            return paint;
        }

        public void Game()
        {
            int count = 0;
            do
            {
                switch (rand.Next(1, 5))
                {

                    case 1:
                        if (MessageBox. ("Feed", "I want", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Feed();
                            count = 0;
                        }
                        else
                        {
                            Bad();
                            count++;
                        }

                        break;
                    case 2:
                        if (MessageBox.Show("Walk", "I want", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            Walk();
                            count = 0;
                        }

                        else
                        {
                            Bad();
                            count++;
                        }

                        break;
                        // и тд
                        //если 3 раза подряд отказывать, то питомец умирает 
                }
            } while (count != 3);
            MessageBox.Show("Die", "I am", MessageBoxButtons.OK);
            Die();
            
        }
    }
}

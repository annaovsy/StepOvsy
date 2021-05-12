using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankNamespace;
using ClientNamespace;
using AccountNamespace;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Banc banc = new Banc();

            var acc = banc.AddClient("Anna", "Anna25", "1111", 5000);

            Console.WriteLine($"Пользователь успешно зарегистрирован!");
            Console.WriteLine($"Номер вашего счета: {acc}");

            Console.WriteLine($"Введите номер счета:");
            int numbAcc = Int32.Parse(Console.ReadLine());
            int i = 3;
            while(i > 0)
            {
                Console.WriteLine($"Введите пароль: (У Вас {i} попытки)");
                string pass = Console.ReadLine();

                bool checkPass = banc.CheckPasswd(numbAcc, pass);
                if (checkPass)
                {
                    Console.WriteLine($"Выберите действие");
                    Console.WriteLine($"1 - Вывод баланса на экран");
                    Console.WriteLine($"2 - Пополнение счета");
                    Console.WriteLine($"3 - Снять деньги со счета");
                    Console.WriteLine($"4 - Выход");

                    string choise = Console.ReadLine();
                    if(choise == "1")
                        banc.PrintBalance();


                    banc.PrintBalance();

                    banc.Refill(99);
                    banc.PrintBalance();
                    banc.WithdrawMoney(6000);
                    banc.PrintBalance();

                    Console.WriteLine($"ок");
                }
                else
                {
                    Console.WriteLine($"Неверный пароль");
                    i--;
                }                   
            }
            Console.WriteLine("До свидания!");
            
            

        }
    }
}

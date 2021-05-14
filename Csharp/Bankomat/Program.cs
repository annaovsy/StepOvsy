using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankNamespace;
using ClientNamespace;
using AccountNamespace;
using System.Diagnostics;

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
                    while (true) 
                    {
                        Console.WriteLine($"Выберите действие");
                        Console.WriteLine($"1 - Вывод баланса на экран");
                        Console.WriteLine($"2 - Пополнение счета");
                        Console.WriteLine($"3 - Снять деньги со счета");
                        Console.WriteLine($"4 - Выход");

                        string choise = Console.ReadLine();
                        if (choise == "1")
                        {
                            banc.PrintBalance();
                            
                        }
                        else if(choise == "2")
                        {
                            Console.WriteLine("Введите сумму:");
                            double refill = Double.Parse(Console.ReadLine());

                            banc.Refill(refill);
                        }
                        else if (choise == "3")
                        {
                            Console.WriteLine("Введите сумму:");
                            double money = Double.Parse(Console.ReadLine());

                            banc.WithdrawMoney(money);
                        }
                        else if (choise == "4")
                        {
                            Console.WriteLine("До свидания!");
                            Process.GetCurrentProcess().Kill();
                        }

                        Console.ReadKey();
                        Console.Clear();
                    } 
                   
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

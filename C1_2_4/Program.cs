using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string loggin = "root";
            string password = "GeekBrains";
            int tryCount = 3;

            do
            {
                Console.WriteLine("Введите логин");
                string tryGuessLog = Console.ReadLine();
                Console.WriteLine("Введите пороль");
                string tryGuessPass = Console.ReadLine();
                if (tryGuessLog == loggin && tryGuessPass == password)
                {
                    Console.WriteLine("Добро пожаловать");
                    break;
                }
                else
                {
                    Console.WriteLine("Логин или пороль не верен");
                    

                }
                
                tryCount--;
                if (tryCount > 0)
                {
                    Console.WriteLine("Осталось " + tryCount +" попыток");
                }
            } while (tryCount > 0);
            
        }
    }
}

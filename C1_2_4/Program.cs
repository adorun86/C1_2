//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C1_2_4
//{
//    class Program
//    {
//        //Mashkantsev
//        //4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
//        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа 
//        //пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
//        static void Main(string[] args)
//        {
//            string loggin = "root";
//            string password = "GeekBrains";
//            int tryCount = 3;

//            do
//            {
//                Console.WriteLine("Введите логин");
//                string tryGuessLog = Console.ReadLine();
//                Console.WriteLine("Введите пороль");
//                string tryGuessPass = Console.ReadLine();
//                if (tryGuessLog == loggin && tryGuessPass == password)
//                {
//                    Console.WriteLine("Добро пожаловать");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Логин или пороль не верен");
                    

//                }
                
//                tryCount--;
//                if (tryCount > 0)
//                {
//                    Console.WriteLine("Осталось " + tryCount +" попыток");
//                }
//            } while (tryCount > 0);
//            //dsa
//        }
//    }
//}

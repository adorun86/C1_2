//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C1_2_1
//{
//    // Машканцев 
//    //1. Написать метод, возвращающий минимальное из трех чисел.
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите 1 число : ");
//            int a = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Введите 2 число : ");
//            int b = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Введите 3 число: ");
//            int c = Convert.ToInt32(Console.ReadLine());

//            int min;

//            if (a < b && a < c)
//            {
//                min = a;
//            }
//            else
//            {
//                if (b < c)
//                {
//                    min = b;
//                }
//                else
//                {
//                    min = c;
//                }
//            }
//            Console.WriteLine(min);
//            Console.ReadKey();

//        }
//    }
//}

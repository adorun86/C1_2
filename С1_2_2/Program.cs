using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С1_2_2
{
    // Mashkantsev
    //2. Написать метод подсчета количества цифр числа.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string message = Console.ReadLine();

            Console.Write(message.Length);
            Console.ReadKey();
        }
    }
}

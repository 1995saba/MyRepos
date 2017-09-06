using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char symbol;
            Console.WriteLine("Введите символы:");
            Console.WriteLine("Чтобы подсчитать количество введенных Вами пробелов нажмите '.', а затем ENTER.");
            do
            {
                symbol = (char)Console.Read();
                if (symbol == ' ')
                {
                    count++;
                }
            } while (symbol != '.');

            Console.WriteLine("Введено пробелов: "+count);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}

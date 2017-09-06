using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Типа Capslock");
            char letter = (char)0;
            while (letter != '.')
            {
                letter = Console.ReadKey().KeyChar;
                if (letter >= 'а' && letter <= 'я')
                {
                    Console.Write("\b" + (char)(letter - 32));
                }
                else if (letter >= 'А' && letter <= 'Я')
                {
                    Console.Write("\b" + (char)(letter + 32));
                }

                else if (letter >= 'a' && letter <= 'z')
                {
                    Console.Write("\b" + (char)(letter - 32));
                }
                else if (letter >= 'A' && letter <= 'Z')
                {
                    Console.Write("\b" + (char)(letter + 32));
                }
            }
            Console.ReadLine();
        }
    }
}

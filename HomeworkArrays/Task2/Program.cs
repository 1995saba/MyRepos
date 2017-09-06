using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер билета(6-ти значное число): ");
            string numberAsString = Console.ReadLine();

            char[] numbers = numberAsString.ToCharArray();

            var firstPart = numbers[0] + numbers[1] + numbers[2];
            var secondPart = numbers[3] + numbers[4] + numbers[5];

            if (firstPart==secondPart)
            {
                Console.WriteLine("Счастливый билетик!");
            }
            else if (firstPart != secondPart)
            {
                Console.WriteLine("Простой билетик");
            }
            Console.ReadLine();
        }
    }
}

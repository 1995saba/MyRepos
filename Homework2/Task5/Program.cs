using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число: ");
            string numStr = Console.ReadLine();
            int num = Int32.Parse(numStr);

            int dozens = num / 10;
            int units = num % 10;
            Console.WriteLine("В числе " + dozens + " десятков и " + units + " единиц.");

            int sum = dozens + units;
            Console.WriteLine("Сумма цифр = " + sum);

            int composition = dozens * units;
            Console.WriteLine("Произведение цифр = " + composition);

            Console.ReadLine();
        }
    }
}

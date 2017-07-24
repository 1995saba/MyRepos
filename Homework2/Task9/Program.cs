using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение сопротивления первого участка электрической цепи (Ом):");
            string rOneAsString = Console.ReadLine();
            int rOne = Int32.Parse(rOneAsString);

            Console.WriteLine("Введите значение напряжения первого участка электрической цепи (Вольт):");
            string uOneAsString = Console.ReadLine();
            int uOne = Int32.Parse(uOneAsString);

            Console.WriteLine("Введите значение сопротивления второго участка электрической цепи (Ом):");
            string rTwoAsString = Console.ReadLine();
            int rTwo = Int32.Parse(rTwoAsString);

            Console.WriteLine("Введите значение напряжения второго участка электрической цепи (Вольт):");
            string uTwoAsString = Console.ReadLine();
            int uTwo = Int32.Parse(uTwoAsString);

            double iOne = uOne / rOne;
            double iTwo = uTwo / rTwo;

            if (iOne > iTwo)
            {
                Console.WriteLine("Меньший ток протекает по второму участку.");
            }

            else if (iOne < iTwo)
            {
                Console.WriteLine("Меньший ток протекает по первому участку.");
            }

            else if (iOne == iTwo)
            {
                Console.WriteLine("Оба участка имеют равную силу тока.");
            }

            Console.ReadLine();
        }
    }
}

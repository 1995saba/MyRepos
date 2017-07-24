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
            Console.WriteLine("Введите значение в см: ");
            string cmStr = Console.ReadLine();

            double metres = Int32.Parse(cmStr) / 100.00;
            Console.WriteLine("Это " + metres + " метра(ов).");

            Console.ReadLine();
        }
    }
}

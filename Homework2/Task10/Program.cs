using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i <= 35; ++i)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("Введите целое число большее 10:");
            string bStr = Console.ReadLine();
            int b = Int32.Parse(bStr);
            Console.WriteLine();
            for(int i = 10; i <= b; ++i)
            {
                Console.WriteLine(i*i);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Введите положительное целое число меньшее 50:");
            string aStr = Console.ReadLine();
            int a = Int32.Parse(aStr);
            Console.WriteLine();
            for (int i = a; i <= 50; ++i)
            {
                Console.WriteLine(i * i * i);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Введите начальную границу диапазона:");
            string numAStr = Console.ReadLine();
            int numA = Int32.Parse(numAStr);

            Console.WriteLine("Введите конечную границу диапазона:");
            string numBStr = Console.ReadLine();
            int numB = Int32.Parse(numBStr);
            Console.WriteLine();

            for (int i = numA; i <= numB; ++i)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

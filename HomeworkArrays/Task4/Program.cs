using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите начало диапазона: ");
            string aAsString = Console.ReadLine();
            bool aResult = Int32.TryParse(aAsString, out a);
            if (!aResult)
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   aAsString == null ? "<null>" : aAsString);
            }

            Console.WriteLine("Введите конец диапазона: ");
            string bAsString = Console.ReadLine();
            bool bResult = Int32.TryParse(bAsString, out b);
            if (!bResult)
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   bAsString == null ? "<null>" : bAsString);
            }
            Console.WriteLine();

            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

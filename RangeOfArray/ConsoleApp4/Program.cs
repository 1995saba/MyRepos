using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray rangeOfArrays = new RangeOfArray();
            
            Console.WriteLine("Введите нижний индекс допустимого диапазона: ");
            string subscriptAsString = Console.ReadLine();
            rangeOfArrays.Subscript = Int32.Parse(subscriptAsString);

            Console.WriteLine("Введите верхний индекс допустимого диапазона: ");
            string superscriptAsString = Console.ReadLine();
            rangeOfArrays.Superscript = Int32.Parse(superscriptAsString);

            for(int i = rangeOfArrays.Subscript; i <= rangeOfArrays.Superscript; i++)
            {
                Console.WriteLine("a[" + i + ']');
            }

            Console.ReadLine();
        }
    }
}

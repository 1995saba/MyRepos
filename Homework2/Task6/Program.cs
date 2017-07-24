using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            bool c = false;

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);

            bool aOrB = a || b;
            Console.WriteLine("A or B = " + aOrB);

            bool aAndB = a && b;
            Console.WriteLine("A and B = " + aAndB);

            bool bOrC = b || c;
            Console.WriteLine("B or C = " + bOrC);

            Console.ReadLine();
        }
    }
}

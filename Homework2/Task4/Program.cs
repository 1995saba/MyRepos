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
            int days = 234;
            int daysInWeek = 7;
            int weeks = days / daysInWeek;
            Console.WriteLine("234 дня = " + weeks + " недели");

            Console.ReadLine();
        }
    }
}

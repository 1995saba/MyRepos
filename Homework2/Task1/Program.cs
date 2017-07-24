using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(100) + "  " + rand.Next(100) + "  " + rand.Next(100));
            Console.ReadLine();
        }
    }
}

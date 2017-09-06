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
            int number;

            Console.WriteLine("Введите любое целое положительное число:");
            string numberAsString = Console.ReadLine();
            bool result = Int32.TryParse(numberAsString, out number);
            if (!result)
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   numberAsString == null ? "<null>" : numberAsString);
            }

            int[] reverseNumber = new int[numberAsString.Length];
            for (int i = 0; i < numberAsString.Length; i++)
            {
                reverseNumber[i] = Convert.ToInt32(numberAsString[(numberAsString.Length - 1) - i]) - 48;
            }
           
            for (int i = 0; i < numberAsString.Length; i++)
            {
                Console.Write(reverseNumber[i]);
            }

            Console.ReadLine();
        }
    }
}

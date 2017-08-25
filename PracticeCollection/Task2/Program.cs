using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int listSize;
            Console.WriteLine("Введите значение для количества элементов в коллекции: ");
            string listSizeAsString = Console.ReadLine();
            bool result = Int32.TryParse(listSizeAsString, out listSize);
            if (!result)
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   listSizeAsString == null ? "<null>" : listSizeAsString);
            }
            Console.WriteLine();

            int sum=0;
            var numbers=new List<int>();
            for (int i = 0; i < listSize; i++)
            {
                numbers.Add(i);
                Console.WriteLine(numbers[i]);
                sum += i;
            }
            double average = sum / listSize;
            Console.WriteLine();

            for (int i = 0; i < listSize; i++)
            {
                if (numbers[i]>average) {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.ReadLine();
        }
    }
}

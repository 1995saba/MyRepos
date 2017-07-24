using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение объема первого тела (м куб.):");
            string volumeOneAsString = Console.ReadLine();
            int volumeOne = Int32.Parse(volumeOneAsString);

            Console.WriteLine("Введите значение массы первого тела (кг):");
            string massOneAsString = Console.ReadLine();
            int massOne = Int32.Parse(massOneAsString);

            Console.WriteLine("Введите значение объема второго тела (м куб.):");
            string volumeTwoAsString = Console.ReadLine();
            int volumeTwo = Int32.Parse(volumeTwoAsString);

            Console.WriteLine("Введите значение массы второго тела (кг):");
            string massTwoAsString = Console.ReadLine();
            int massTwo = Int32.Parse(massTwoAsString);

            double densityOne = massOne / volumeOne;
            double densityTwo = massTwo / volumeTwo;

            if (densityOne > densityTwo)
            {
                Console.WriteLine("Первое тело имеет большую плотность.");
            }

            else if (densityOne > densityTwo)
            {
                Console.WriteLine("Второе тело имеет большую плотность.");
            }

            else if (densityOne == densityTwo)
            {
                Console.WriteLine("Тела имеют равную плотность.");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса круга: ");
            string radiusAsString = Console.ReadLine();
            int radius = Int32.Parse(radiusAsString);

            Console.WriteLine("Введите значение стороны квадрата: ");
            string sideAsString = Console.ReadLine();
            int side = Int32.Parse(sideAsString);

            double sqrOfRound = Math.PI * radius * radius;
            double sqrOfSquare = side * side;

            if (sqrOfRound > sqrOfSquare)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (sqrOfRound < sqrOfSquare)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else if (sqrOfRound == sqrOfSquare)
            {
                Console.WriteLine("Площадь круга равна площади квадрата.");
            }

            Console.ReadLine();
        }
    }
}

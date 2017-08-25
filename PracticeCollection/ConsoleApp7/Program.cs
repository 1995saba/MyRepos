using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayListSize;
            Console.WriteLine("Введите значение для количества элементов в ArrayList: ");
            string arrayListSizeAsString = Console.ReadLine();
            bool result = Int32.TryParse(arrayListSizeAsString, out arrayListSize);
            if (!result)
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   arrayListSizeAsString == null ? "<null>" : arrayListSizeAsString);
            }
            Console.WriteLine();

            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < arrayListSize; i++)
            {
                arrayList.Add(i);
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine();

            ArrayList newArrayList = new ArrayList();
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    newArrayList.Add(arrayList[i]);
                }
            }
            arrayList.Clear();

            for (int i = 0; i < newArrayList.Count; i++)
            {
                Console.WriteLine(newArrayList[i]);
            }

            Console.ReadLine();
        }
    }
}

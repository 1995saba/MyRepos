using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookCollection = new List<Book>();
            string path = @"C:\data";
            FileStream stream = new FileStream(path + @"\book.dat", FileMode.Open);

        }
    }
}

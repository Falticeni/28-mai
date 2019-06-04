using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercitiul1.Classes;
using System.IO;

namespace Exercitiul1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti adresa textului: ");
            string Path = Console.ReadLine();
            ReadText.ReadAllText(Path);

            Console.ReadKey();
        }
    }

}

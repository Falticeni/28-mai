using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Curs_28_mai
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            double Radical(double nr)
            {
                if (nr <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return Math.Sqrt(nr);
            }
            Console.Write("Selectati numarul:");
            while (x < 1)
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    double y = Radical(x);
                    Console.WriteLine("Radicalul numarului {0} este {1:F3}", x, y);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Introduceti un numar mai mare ca 0: ");
                }
                catch (FormatException)
                {
                    Console.Write("Introduceti un numar format doar din cifre:");
                }
                catch (OverflowException)
                {
                    Console.Write("Introduceti un numar format din mai putine cifre:");
                }
                finally
                {
                    Console.WriteLine("Goodbye!");
                }
            }


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti numarul de inceput: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de final: ");
            int z = Convert.ToInt16(Console.ReadLine());
            int b = a;                          //  numarul anterior
            int[] arr = new int[10];


            for (int i = 1; i <= 10; i++)
            {
                int nr = 0;
                while ((nr <= a) || (nr >= z) || (nr < b))
                {
                    {
                        Console.WriteLine("Introduceti numarul {0}: ", i);
                        try
                        {
                            nr = Convert.ToInt16(Console.ReadLine());
                            if (nr <= a || nr >= z)
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                            if (nr <= b)
                            {
                                throw new InvalidOperationException();
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Number was out of the range ({0}..{1})!", a, z);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error! Cannot convert this input to integer. Try again.");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Input number is too big or too small to fit in int data type.Try again.");
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("The number is smaller or equal than previous number.Please try again with bigger one.");
                        }
                        if (nr > b)
                        {
                            b = nr;
                        }
                    }
                }

                arr[i - 1] = nr;
            }



            Console.Write("{0} < ", a);
            foreach (int element in arr)
            {
                Console.Write("{0} < ", element);
            }
            Console.Write(z);

            Console.ReadKey();
        }
    }
}

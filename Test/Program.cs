using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ints = { 10, 45, 15, 39, 21, 26 };
            //var result = ints.OrderBy(g => g);
            //foreach (var i in result)
            //{
            //    System.Console.Write(i + " ");
            //}
            //Console.WriteLine("");

            //Console.WriteLine(STF.WordCount("Robert cel Mare!"));
            //var x = "Robert cel mai mare!";
            //var y = x.WordCount();
            //Console.WriteLine(x.WordCount());


            //int i = 10;
            //string j = "1, 2, 3, 4, 5";
            //Console.WriteLine(i.IsGreaterThan(8));
            //Console.WriteLine(j.WordCount());


            //    public delegate int SomeOperation(int i, int j);
            //SomeOperation add = FRN.Sum;

            //int result = add(10, 10);

            //public Program(SomeOperation add, int result)
            //{
            //    this.add = add;
            //    this.result = result;
            //}

            //Console.WriteLine(result);

            bool IsUpperCase(string str)
            {
                return str.Equals(str.ToUpper());
            }

            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("HHH!!");

            Console.WriteLine(result);
        }
}
}

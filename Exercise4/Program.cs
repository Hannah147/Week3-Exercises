using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query = from number in numbers
                        select DoubleIt(number);

            var query2 = numbers
                .Select(n => DoubleIt(n));

            WriteLine("Before the foreach loop");

            foreach(var item in query)
            {
                WriteLine($"{item}\n");
            }


        }

        private static int DoubleIt(int value)
        {
            WriteLine("About to double the number " + value.ToString());
            return value * 2;
        }
    }
}

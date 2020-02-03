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
            WriteLine("Query Syntax");
            QuerySyntax();

            WriteLine("Lambda Syntax");
            LambdaSyntax();
        }

        private static int DoubleIt(int value)
        {
            WriteLine("About to double the number " + value.ToString());
            return value * 2;
        }

        static void QuerySyntax()
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query = from number in numbers
                        select DoubleIt(number);

            WriteLine("Before the foreach loop");

            foreach (var item in query)
            {
                WriteLine($"{item}\n");
            }
        }

        static void LambdaSyntax()
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query2 = numbers
                .Select(n => DoubleIt(n));

            WriteLine("Before the foreach loop");

            foreach (var item in query2)
            {
                WriteLine($"{item}\n");
            }
        }
    }
}

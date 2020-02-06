using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Query Syntax");
            QuerySyntax();

            WriteLine("\n\nLambda Syntax");
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

            var query1 = from number in numbers
                         orderby number descending
                         select number;

            var query2 = from number in query1
                         where number < 8
                         select number;

            var query3 = from number in query2
                         select DoubleIt(number);

            foreach (var item in query3)
            {
                WriteLine(item);
            }
        }

        static void LambdaSyntax()
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query1 = numbers.OrderByDescending(n => n);

            var query2 = query1.Where(n => n < 8);

            var query3 = query2.Select(n => DoubleIt(n));

            foreach(var item in query3)
            {
                WriteLine(item);
            }

            var query4 = numbers
                .OrderByDescending(n => n)
                .Where(n => n < 8)
                .Select(n => DoubleIt(n));
        }
    }
}

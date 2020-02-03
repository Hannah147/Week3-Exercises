using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week3_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            QuerySyntax();

            LambdaSyntax();
        }

        static void QuerySyntax()
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var outputNumbers = from number in numbers
                                where number > 5
                                orderby number descending
                                select number;

            foreach(int number in outputNumbers)
            {
                WriteLine(number.ToString()); 
            }
        }

        static void LambdaSyntax()
        {

        }
    }
}

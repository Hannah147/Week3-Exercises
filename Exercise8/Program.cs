using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise8
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

        static void QuerySyntax()
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var query = from name in names
                        where name.StartsWith("M")
                        orderby name ascending
                        select name;

            foreach (var item in query)
            {
                WriteLine(item);
            }
        }

        static void LambdaSyntax()
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var query = names
                .Where(n => n.StartsWith("M"))
                .OrderBy(n => n);

            foreach (var item in query)
            {
                WriteLine(item);
            }
        }
    }
}

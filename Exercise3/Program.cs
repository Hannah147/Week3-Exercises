using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Exercise3
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

        static void QuerySyntax()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };

            WriteLine("Filename\tSize\t\tCreation Date");

            foreach (var item in query)
            {
                WriteLine("{0} \t{1} bytes, \t{2}", item.Name, item.Length, item.CreationTime);
            }

            WriteLine("\n\n\n");
        }

        static void LambdaSyntax()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = files
                .Where(f => f.Length > 10000)
                .OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new
                {
                    Name = f.Name,
                    Length = f.Length,
                    CreationTime = f.CreationTime
                });

            WriteLine("Filename\tSize\t\tCreation Date");

            foreach (var item in query)
            {
                WriteLine("{0} \t{1} bytes, \t{2}", item.Name, item.Length, item.CreationTime);
            }

        }
    }
}

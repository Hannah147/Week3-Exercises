using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise9_10
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
            var query = from customer in GetCustomers()
                        where customer.City == "Dublin"
                        select customer;

            foreach(var item in query)
            {
                WriteLine(item);
            }
        }

        static void LambdaSyntax()
        {
            var query = GetCustomers()
                .Where(n => n.City == "Dublin");

            foreach (var item in query)
            {
                WriteLine(item);
            }
        }

        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            return customers;
        }
    }

    public class Customer
    {
        public string Name;
        public string City;

        public override string ToString()
        {
            return $"{Name} - {City}";
        }
    }
}

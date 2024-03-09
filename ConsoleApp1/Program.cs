using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Annonymous class
            var customer = new { 
            Name="Rahman", Subject="CSE", Age=20
            };
            Console.WriteLine(customer.Name);

            var customers = new[] {
new { CustomerID = 1, FirstName = "Kim", LastName =
"Abercrombie",
CompanyName = "Alpine Ski House" },
new { CustomerID = 2, FirstName = "Jeff", LastName =
"Hay",
CompanyName = "Coho Winery" },
new { CustomerID = 3, FirstName = "Charlie", LastName =
"Herb",
CompanyName = "Alpine Ski House" },
new { CustomerID = 4, FirstName = "Chris", LastName =
"Preston",
CompanyName = "Trey Research" },
new { CustomerID = 5, FirstName = "Dave", LastName =
"Barnett",
CompanyName = "Wingtip Toys" },
new { CustomerID = 6, FirstName = "Ann", LastName =
"Beebe",
CompanyName = "Coho Winery" },
new { CustomerID = 7, FirstName = "John", LastName =
"Kane",
CompanyName = "Wingtip Toys" },
new { CustomerID = 8, FirstName = "David", LastName =
"Simpson",
CompanyName = "Trey Research" },
new { CustomerID = 9, FirstName = "Greg", LastName =
"Chapman",
CompanyName = "Wingtip Toys" },
new { CustomerID = 10, FirstName = "Tim", LastName =
"Litton",
CompanyName = "Wide World Importers" }
};
            var addresses = new[] {
new { CompanyName = "Alpine Ski House", City = "Berne",
Country = "Switzerland"},
new { CompanyName = "Coho Winery", City = "San Francisco",
Country = "United States"},
new { CompanyName = "Trey Research", City = "New York",
Country = "United States"},
new { CompanyName = "Wingtip Toys", City = "London",
Country = "United Kingdom"},
new { CompanyName = "Wide World Importers", City =
"Tetbury",
Country = "United Kingdom"}
};
            //query

            var result = from c in customers
                         orderby c.FirstName
                         select c;
            Console.Write($"Full Name \t CompanyName \n");
            Console.WriteLine("=======================================");
            foreach (var item in result)
            {
                Console.Write($"{item.FirstName} {item.LastName}\t{item.CompanyName}\n");
            }

            //expression method
            Console.WriteLine("=========Expression Method=========");
            Console.Write($"Full Name \t CompanyName \n");
            Console.WriteLine("=======================================");
            
            customers.ToList().ForEach(item => Console.Write($"{item.FirstName} {item.LastName}\t{item.CompanyName}\n"));
            Console.WriteLine($"Total customer:{customers.Count()}");
            var cust = customers.ToList();
            Console.Write($"Full Name \t CompanyName \n");
            Console.WriteLine("=======================================");
            var output = cust.OrderBy(t => t.FirstName).ThenBy(t=> t.CompanyName).ToList();
            output.ForEach(item => Console.Write($"{item.FirstName} {item.LastName}\t{item.CompanyName}\n"));
            Console.WriteLine("==========DIsplay details of Kim=============================");
            output.Where(p => p.FirstName.ToLower().Equals("kim")).ToList().ForEach(item => Console.Write($"{item.FirstName} {item.LastName}\t{item.CompanyName}\n"));
            Console.WriteLine("==========DIsplay details of whose name start with d=============================");
            output.Where(p => p.FirstName.ToLower().StartsWith("d")).ToList().ForEach(item => Console.Write($"{item.FirstName} {item.LastName}\t{item.CompanyName}\n"));
            Console.WriteLine("==========DIsplay details of whose name end with d=============================");
            output.Where(p => p.FirstName.ToLower().EndsWith("d")).ToList().ForEach(item => Console.Write($"{item.FirstName} {item.LastName}\t{item.CompanyName}\n"));

            Console.WriteLine("==========DIsplay details of whose name contain d=============================");
            output.Where(p => p.FirstName.ToLower().Contains("d")).ToList().ForEach(item => Console.Write($"{item.FirstName} {item.LastName}\t{item.CompanyName}\n"));
            var firstitem= output.FirstOrDefault();
            Console.WriteLine("==========First one==========");
            Console.Write($"{firstitem.FirstName} {firstitem.LastName}\t{firstitem.CompanyName}\n");
            Console.WriteLine("==========Last one==========");
            var lastitem = output.LastOrDefault();
            Console.Write($"{lastitem.FirstName} {lastitem.LastName}\t{lastitem.CompanyName}\n");
            Console.ReadKey();
        }
    }
}

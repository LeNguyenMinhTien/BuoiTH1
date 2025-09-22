using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Optimized
{
    public class Program
    {
        static void Main()
        {
            // Facade
            var mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            var customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            string result = eligible ? "Approved" : "Rejected";
            WriteLine($"\n{customer.Name} has been {result}");

            // Wait for user
            ReadKey();
        }
    }
}

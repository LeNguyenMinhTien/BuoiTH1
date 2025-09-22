using static System.Console;

namespace Optimized
{
    public class Program
    {
        public static void Main()
        {
            // Create RefinedAbstraction and set ConcreteImplementor
            var customers = new Customers(
                new CustomersData("Chicago"));

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();

            customers.Add("Henry Velasquez");
            customers.ShowAll();

            ReadKey();
        }
    }
}

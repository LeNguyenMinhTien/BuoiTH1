using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Optimized
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine($"Check credit for {c.Name}");
            return true;
        }
    }
}

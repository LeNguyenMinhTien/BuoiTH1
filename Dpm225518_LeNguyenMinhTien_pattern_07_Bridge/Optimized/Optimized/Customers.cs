using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Optimized
{
    // RefinedAbstraction
    public class Customers : CustomersBase
    {
        public Customers(IDataObject<string> dataObject)
            : base(dataObject)
        {
        }

        public override void ShowAll()
        {
            WriteLine();
            WriteLine("------------------------");
            base.ShowAll();
            WriteLine("------------------------");
        }
    }
}
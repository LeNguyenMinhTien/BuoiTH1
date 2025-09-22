using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Optimized
{
    public class Lion : ICarnivore
    {
        // Eat Wildebeest
        public void Eat(IHerbivore h) =>
            Console.WriteLine($"{GetType().Name} eats {h.GetType().Name}");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized
{
    public class America : IContinentFactory
    {
        public IHerbivore CreateHerbivore() => new Bison();
        public ICarnivore CreateCarnivore() => new Wolf();
    }
}

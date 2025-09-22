using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized
{
    public class Shape : IComparable<Shape>
    {
        private readonly string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public int CompareTo(Shape other)
        {
            return (this == other) ? 0 : -1;
        }
    }
}

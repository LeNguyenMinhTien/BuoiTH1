using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized
{
    using System;

    namespace Optimized
    {
        public abstract class Decorator<T> : LibraryItem<T>
        {
            protected LibraryItem<T> libraryItem;

            public Decorator(LibraryItem<T> libraryItem)
            {
                this.libraryItem = libraryItem;
            }

            public override void Display()
            {
                libraryItem.Display();
            }
        }
    }
}
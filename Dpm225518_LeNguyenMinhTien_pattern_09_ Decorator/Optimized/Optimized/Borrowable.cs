using Optimized.Optimized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized
{
    public class Borrowable<T> : Decorator<T>
    {
        private readonly List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem<T> libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            NumCopies++;
        }

        public override void Display()
        {
            base.Display();
            foreach (var borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}

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
        public static void Main()
        {
            var root = new TreeNode<Shape> { Node = new Shape("Picture") };
            root.Add(new Shape("Red Line"));
            root.Add(new Shape("Blue Circle"));
            root.Add(new Shape("Green Box"));

            var branch = root.Add(new Shape("Two Circles"));
            branch.Add(new Shape("Black Circle"));
            branch.Add(new Shape("White Circle"));

            var shape = new Shape("Yellow Line");
            root.Add(shape);
            root.Remove(shape);
            root.Add(shape);

            TreeNode<Shape>.Display(root, 1);

            ReadKey(); // hợp lệ nhờ using static System.Console
        }
    }
}
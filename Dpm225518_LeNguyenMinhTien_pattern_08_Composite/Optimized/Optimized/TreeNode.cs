using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public TreeNode<T> Add(T child)
        {
            var newNode = new TreeNode<T> { Node = child };
            Children.Add(newNode);
            return newNode;
        }

        public void Remove(T child)
        {
            foreach (var treeNode in Children)
            {
                if (treeNode.Node.CompareTo(child) == 0)
                {
                    Children.Remove(treeNode);
                    return;
                }
            }
        }

        public T Node { get; set; }

        public List<TreeNode<T>> Children { get; } = new List<TreeNode<T>>();

        public static void Display(TreeNode<T> node, int indentation)
        {
            var line = new string('-', indentation);
            Console.WriteLine(line + " " + node.Node);
            node.Children.ForEach(n => Display(n, indentation + 1));
        }

    }

}
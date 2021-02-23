using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeLib;

namespace BSTTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bstree = new BST();
            bstree.Clear();
            bstree.Add(5);
            bstree.Add(7);
            bstree.Add(2);
            bstree.Add(10);
            bstree.Add(21);
            bstree.Add(4);
            bstree.Add(9);
            bstree.Add(15);

            Console.WriteLine("addtext {0}", bstree.Count(bstree.Root));
            Console.WriteLine();

            InorderTraversal(bstree.Root);
            Console.WriteLine();

            bstree.Delete(4);

            InorderTraversal(bstree.Root);
            Console.WriteLine();

            bstree.Add(10);

            InorderTraversal(bstree.Root);
            Console.WriteLine("\n");

            if (bstree.Search(10) != null)
                Console.WriteLine("addtext");
            else
                Console.WriteLine("addtext");
            Console.WriteLine();


        }
    }
}

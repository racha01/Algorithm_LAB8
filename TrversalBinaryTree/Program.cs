using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeLib;

namespace TrversalBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST btree = new BST();
            btree.Root = new Node(1);
            btree.Root.Left = new Node(2);
            btree.Root.Right = new Node(3);
            btree.Root.Left.Left = new Node(4);
            btree.Root.Right.Right = new Node(5);
            btree.Root.Left.Left.Right = new Node(6);
            btree.Root.Right.Right.Right = new Node(7);
            btree.Root.Right.Right.Right.Right = new Node(8);

            Console.WriteLine("addtext:");
            PreorderTraversal(btree.Root);
            Console.WriteLine("\n");
            


        }
        static void PreorderTraversal(Node current)
        {
            if(current != null)
            {
                Console.Write("{0}", current.Value.ToString());
                PreorderTraversal(current.Left);
                PreorderTraversal(current.Right);
            }
        }
        static void InorderTraversal(Node current)
        {

        }
        static void PostorderTraversal(Node current)
        {

        }
    }
}

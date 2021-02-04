using DataStructures.Trees;
using System;
using System.Collections.Generic;

namespace DataStructures
{
    /// <summary>
    /// Playground class seeing output
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start app");
            //LinkedListStuff();
            //StackStuff();
            Console.WriteLine("end app");
            TreeTest();
        }

        static void StackStuff()
        {

            Stack<string> cats = new Stack<string>();
            cats.Push("Spaceghost");
            cats.Push("Harry");
            cats.Push("Lucipurr");
            cats.Push("Ethel");

            //iterate the stack
            while (!cats.IsEmpty())
            {
                string cat = cats.Pop();
                Console.WriteLine(cat);
            }
                
        }

        static void LinkedListStuff()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Append(2);
            myList.Append(3);
            myList.Append(4);
            myList.Append(5);
            myList.Append(6);
            myList.Append(10);
 
            //myList.InsertAfter(10, 7);

            //Console.WriteLine(myList.ToString());
            //Console.WriteLine("\n");
            //myList.ToStringRecurive(myList.Head);
        }
        static void TreeTest()
        {
            /*
            BinarySearchTree<int> newTree = new BinarySearchTree<int>();
            newTree.Add(newTree.Root, 9);
            newTree.Add(newTree.Root, 4);
            newTree.Add(newTree.Root, 17);
            newTree.Add(newTree.Root, 3);
            newTree.Add(newTree.Root, 6);
            newTree.Add(newTree.Root, 22);
            newTree.Add(newTree.Root, 5);
            newTree.Add(newTree.Root, 7);
            newTree.Add(newTree.Root, 20);

            List<int> result = newTree.BreadthFirst();
            foreach (int value in result)
                Console.WriteLine($"{value} -> ");

            BinarySearchTree<int> test = new BinarySearchTree<int>();
            */
            // last leaves
            KNode<int> n1 = new KNode<int>(7);
            KNode<int> n2 = new KNode<int>(13);
            KNode<int> n3 = new KNode<int>(30);
            KNode<int> n4 = new KNode<int>(10);
            KNode<int> n5 = new KNode<int>(3);
            KNode<int> n6 = new KNode<int>(8);
            KNode<int> n7 = new KNode<int>(8);

            // middle tier
            List<KNode<int>> children = new List<KNode<int>>() { n1, n2, n3 };
            KNode<int> n8 = new KNode<int>(4, children);

            children = new List<KNode<int>>() { n4 };
            KNode<int> n9 = new KNode<int>(5, children);

            children = new List<KNode<int>>() { n5, n6, n7 };
            KNode<int> n10 = new KNode<int>(15, children);

            //root
            children = new List<KNode<int>>() { n8, n9, n10 };
            KNode<int> n11 = new KNode<int>(3, children);

            KAryTree<int> newTree = new KAryTree<int>(3);
            newTree.Root = n11;

            Console.WriteLine(newTree.Root.Value);

            List<KNode<int>> list = newTree.Root.Children;

            foreach (var child in list)
                Console.WriteLine(child.Value);
        }
    }
}

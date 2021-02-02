using DataStructures.Trees;
using System;

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
            Console.WriteLine("tree");
            BinaryTree<char> newTree = new BinaryTree<char>();

            Trees.Node<char> nodeA = new Trees.Node<char>('A');
            Trees.Node<char> nodeB = new Trees.Node<char>('B');
            Trees.Node<char> nodeC = new Trees.Node<char>('C');
            Trees.Node<char> nodeD = new Trees.Node<char>('D');
            Trees.Node<char> nodeE = new Trees.Node<char>('E');
            Trees.Node<char> nodeF = new Trees.Node<char>('F');

            nodeA.Left = nodeB;
            nodeA.Right = nodeC;
            nodeB.Left = nodeD;
            nodeB.Right = nodeE;
            nodeC.Left = nodeF;

            newTree.Root = nodeA;

            newTree.PreOrder();

        }
    }
}

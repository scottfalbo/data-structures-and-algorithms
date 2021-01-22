using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            StackStuff();
        }

        static void StackStuff()
        {

            Stacks<string> cats = new Stacks<string>();
            cats.Push("Spaceghost");
            cats.Push("Harry");
            cats.Push("Lucipurr");
            cats.Push("Ethel");

            //iterate the stack
            while (!cats.IsEmpty())
            {
                Node<string> cat = cats.Pop();
                Console.WriteLine(cat.Value);
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

            Console.WriteLine("start app");
            //myList.InsertAfter(10, 7);


            //Console.WriteLine(myList.ToString());
            //Console.WriteLine("\n");
            //myList.ToStringRecurive(myList.Head);
            Console.WriteLine("end app");
        }
    }
}

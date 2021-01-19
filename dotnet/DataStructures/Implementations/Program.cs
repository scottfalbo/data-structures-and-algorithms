using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.Insert(2);
            myList.Insert(3);
            myList.Insert(4);
            myList.Insert(5);
            myList.Insert(6);
            myList.Append(10);

            Console.WriteLine(myList.ToString());
            //Console.WriteLine("\n");
            //myList.ToStringRecurive(myList.Head);

        }

    }
}

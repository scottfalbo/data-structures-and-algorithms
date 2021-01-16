using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList(1);
            myList.Insert(2);
            myList.Insert(3);
            myList.Insert(4);
            myList.Insert(5);
            myList.Insert(6);

            myList.PrintMe();
            Console.WriteLine("\n");
            myList.PrintWithRecusion(myList.Head);
       }

    }
}

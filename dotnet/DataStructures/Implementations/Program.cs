using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.Append(2);
            myList.Append(3);
            myList.Append(4);
            myList.Append(5);
            myList.Append(6);
            myList.Append(10);

            Console.WriteLine("start app");
            //myList.InsertAfter(10, 7);
            int result = myList.KthFromEnd(4);


            Console.WriteLine(result);
            //Console.WriteLine(myList.ToString());
            //Console.WriteLine("\n");
            //myList.ToStringRecurive(myList.Head);
            Console.WriteLine("end app");
        }

    }
}

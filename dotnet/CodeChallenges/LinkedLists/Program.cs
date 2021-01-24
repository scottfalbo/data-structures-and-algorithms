using System;
using DataStructures;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// Code challenge 1
        /// </summary>
        public static bool LinkListActivity()
        {
            LinkedList<int> myList = new LinkedList<int>(3);
            myList.Insert(6);
            Console.WriteLine(myList.Head.Value);
            return myList.Head != null;
        }
    }
}

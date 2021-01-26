using System;
using DataStructures;

namespace Challenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> listA = new LinkedList<int>();
            listA.Append(1);
            listA.Append(3);
            listA.Append(5);

            LinkedList<int> listB = new LinkedList<int>();
            listA.Append(2);
            listA.Append(4);
            listA.Append(6);
            Node<int> testReference = LLZip.ZipList(listA, listB);
            LinkedList<int> testList = new LinkedList<int>(testReference);

            string result = testList.ToString();
            Console.WriteLine(testList);
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

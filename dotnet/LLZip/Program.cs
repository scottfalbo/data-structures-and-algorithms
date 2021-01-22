using System;
using DataStructures;

namespace LLZip
{
    public class Program
    {
        /*
        static void Main(string[] args)
        {
            LinkedList listA = new LinkedList();
            listA.Append(1);
            listA.Append(3);
            listA.Append(5);

            LinkedList listB = new LinkedList();
            listA.Append(2);
            listA.Append(4);
            listA.Append(6);

            //ZipList(listA, listB);
        }

        public static Node ZipList(LinkedList listA, LinkedList listB)
        {
            //if (listA.ListLength() == 0 || listB.ListLength() == 0)
              //  return null;
            

            LinkedList newList = new LinkedList(listA.Head);
            Node nodeA = listA.Head.Next;
            Node nodeB = listB.Head;
            Node nodeC = newList.Head;

            while (nodeA != null && nodeB != null)
            {
                if (nodeA == null && nodeB != null)
                {
                    nodeC.Next = nodeB;
                    break;
                }
                if (nodeB == null && nodeA != null)
                {
                    nodeC.Next = nodeA;
                    break;
                }
                nodeC.Next = nodeB;
                nodeB = nodeB.Next;
                nodeC = nodeC.Next;
                nodeC.Next = nodeA;
                nodeA = nodeA.Next;
                nodeC = nodeC.Next;
            }

            return newList.Head;
        }
        */
    }
}

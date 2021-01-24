using System;
using System.Text;
using DataStructures;

namespace LinkedLists
{
    public class LLZip
    {
        public static Node<int> ZipList(LinkedList<int> listA, LinkedList<int> listB)
        {
            //if (listA.ListLength() == 0 || listB.ListLength() == 0)
            //  return null;

            LinkedList<int> newList = new LinkedList<int>(listA.Head);
            Node<int> nodeA = listA.Head.Next;
            Node<int> nodeB = listB.Head;
            Node<int> nodeC = newList.Head;
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
    }
}

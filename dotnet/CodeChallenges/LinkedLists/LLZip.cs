using System;
using System.Text;
using DataStructures;

namespace LinkedLists
{
    public class LLZip
    {
        public static Node<int> ZipList(LinkedList<int> listA, LinkedList<int> listB)
        {
            // Variables to track the current nodes while we iterate
            Node<int> currentA = listA.Head;
            Node<int> currentB = listB.Head;

            // Two discard variables to temporarly hold nodes
            _ = new Node<int>();
            _ = new Node<int>();

            // Iterates as long as one of the lists has items in it.
            while (currentA != null && currentB != null)
            {
                // Member nodeA Next, and the set it's Next to nodeB
                Node<int> memberberryA = currentA.Next;
                currentA.Next = currentB;

                // If listA runs out first we have to break to avoid a null reference exception
                if (memberberryA == null)
                    break;

                // Member nodeB Next, and set it's Next to memberA (nodeA original Next)
                Node<int> memberberryB = currentB.Next;
                currentB.Next = memberberryA;

                currentA = memberberryA;
                currentB = memberberryB;
            }

            return listA.Head;
        }
    }
}

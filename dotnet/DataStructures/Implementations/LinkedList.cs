using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    { 
        public Node Head { get; set; }

        /// <summary>
        /// Plain, Empty Linked List
        /// Head will be null
        /// Usage: LinkedList myList = new LinkedList();
        /// </summary>
        public LinkedList() { }

        /// <summary>
        /// Linked List constructor that creates a Head Node
        /// usage: LinkedList myList = new LinkedList(5);
        /// </summary>
        /// <param name="value"></param>
        public LinkedList(int value)
        {
            Node node = new Node(value);
            Head = node;
        }

        /// <summary>
        /// Insert a new node and make it the new Head
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Iterate over the list with a while loop and write the Linked List
        /// </summary>
        public override string ToString()
        {
            Node current = Head;
            string returnList = "";

            while (current != null)
            {
                returnList += $"[{current.Value}] => ";
                current = current.Next;
            }
            returnList +=  "Null";
            return returnList;
        }

        /// <summary>
        /// Iterate over the list recursively and write Linked List
        /// </summary>
        public void ToStringRecurive(Node node)
        {
            if (node == null)
            {
                Console.WriteLine("NULL");
                return;
            }
            Console.Write($"[{node.Value}] => ");
            ToStringRecurive(node.Next);
        }

        /// <summary>
        /// Takes in integer and iterates over the linked list, return true if value is present
        /// usage: bool contains = myListObject.Includes(3);
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool Includes(int query)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Value == query)
                    return true;
                current = current.Next;
            }
            return false;
        } 

        /// <summary>
        /// Takes in an integer and appends it to the end of the linked list
        /// usage: myList.Append(5);
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Node newNode = new Node(value);
            Node current = Head;

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            while(current.Next != null)
                current = current.Next;

            current.Next = newNode;
        }

        /// <summary>
        /// Insert a value before a targetted value in a linked list.  Checks for edge cases including:
        /// A list of only one node, an empty list, and missing targetted value.
        /// Usage: myList.InsertBefore(targetValue, newValue);
        /// </summary>
        /// <param name="targetValue"></param>
        /// <param name="newValue"></param>
        public void InsertBefore(int targetValue, int newValue)
        {
            Node newNode = new Node(newValue);
            Node current = Head;

            if (current == null)
            {
                throw new Exception("The Linked List is empty, nothing to insert before");
            }
            else if (current.Next == null)
            {
                Head = newNode;
                newNode.Next = current;
            }
            else
            {
                while (current != null)
                {
                    if (current.Next.Value == targetValue)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        break;
                    }
                    current = current.Next;
                }
            }
            if (newNode.Next == null)
            {
                throw new Exception($"The targetted value of {targetValue} does in exist in the Linked List");
            }
            
        }

        public void InsertAfter(int targetValue, int newValue)
        {
            Node current = Head;
            Node newNode = new Node(newValue);

            if (current == null)
            {
                throw new Exception("The Linked List is empty, nothing to insert before");
            }
            else
            {
                while (current != null)
                {
                    if (current.Value == targetValue)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        break;
                    }
                    current = current.Next;
                }
            }
        }

        public int KthFromEnd(int k)
        {
            Node current = Head;
            int counter = 0;

            if ( k > -1 && Head != null)
            {
                while (current != null)
                {
                    counter++;
                    current = current.Next;
                }
            }
            else
                throw new Exception("Given arguments outside of parameters");

            current = Head;
            if (counter > k)
            {
                for (int i = 0; i < counter-k-1; i++)
                    current = current.Next;
            }
            else
                throw new Exception("Input value out of range");


            return current.Value;
        }

    }
}

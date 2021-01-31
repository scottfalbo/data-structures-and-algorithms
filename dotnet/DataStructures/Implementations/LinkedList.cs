using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList<T>
    { 
        public Node<T> Head { get; set; }

        public int counter = 0;

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
        public LinkedList(T value)
        {
            Node<T> node = new Node<T>(value);
            Head = node;
        }

        public LinkedList(Node<T> node)
        {
            Head = node;
        }

        /// <summary>
        /// Insert a new node and make it the new Head
        /// </summary>
        /// <param name="value"></param>
        public void Insert(T value)
        {
            counter++;
            Node<T> node = new Node<T>(value)
            {
                Next = Head
            };
            Head = node;
        }

        /// <summary>
        /// Returns the length of the list
        /// </summary>
        /// <returns></returns>
        public int ListLength()
        {
            Node<T> current = Head;
            int counter = 0;

            while (current != null)
            {
                counter++;
                current = current.Next;
            }
            return counter;
        }

        /// <summary>
        /// Iterate over the list with a while loop and write the Linked List
        /// </summary>
        public override string ToString()
        {
            Node<T> current = Head;
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
        public void ToStringRecurive(Node<T> node)
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
        public bool Includes(T query)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(query))
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
        public void Append(T value)
        {
            counter++;
            Node<T> newNode = new Node<T>(value);
            Node<T> current = Head;

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
        

        public void InsertBefore(T targetValue, T newValue)
        {
            Node<T> newNode = new Node<T>(newValue);
            Node<T> current = Head;

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
                    if (current.Next.Value.Equals(targetValue))
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

        public void InsertAfter(T targetValue, T newValue)
        {
            Node<T> current = Head;
            Node<T> newNode = new Node<T>(newValue);

            if (current == null)
            {
                throw new Exception("The Linked List is empty, nothing to insert before");
            }
            else
            {
                while (current != null)
                {
                    if (current.Value.Equals(targetValue))
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
            Node<T> current = Head;
            int counter = 0;

            if (k < 0) return -1;
            if (current.Next == null) return -1;

            try
            {
                while (current != null)
                {
                    counter++;
                    current = current.Next;
                }

                current = Head;

                if (counter > k)
                {
                    for (int i = 0; i < (counter - k - 1); i++)
                        current = current.Next;
                }
                else
                {
                    Console.WriteLine("It would appear the input is out of range, womp womp.");
                    throw new ArgumentOutOfRangeException();
                }
                return Convert.ToInt32(current.Value);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Something is amiss.\nThe range is no good, no good at all.\nError: {e}");
            }
            return -1;
        }
        
    }
}

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
        public void PrintMe()
        {
            Node current = Head;

            while (current != null)
            {
                Console.Write($"[{current.Value}] => ");
                current = current.Next;
            }
            Console.Write("Null");
        }

        /// <summary>
        /// Iterate over the list recursively and write Linked List
        /// </summary>
        public void PrintWithRecusion(Node node)
        {
            if (node == null)
            {
                Console.WriteLine("NULL");
                return;
            }
            Console.Write($"[{node.Value}] => ");
            PrintWithRecusion(node.Next);
        }
    }
}

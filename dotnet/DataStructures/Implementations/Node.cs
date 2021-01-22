using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node()
        {

        }

        /// <summary>
        /// Constructor for Node class
        /// Usage Node node = new Node(3);
        /// </summary>
        /// <param name="value"></param>
        public Node(T value)
        {
            Value = value;
        }
    }
}

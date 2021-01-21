using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node()
        {

        }

        /// <summary>
        /// Constructor for Node class
        /// Usage Node node = new Node(3);
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }
    }
}

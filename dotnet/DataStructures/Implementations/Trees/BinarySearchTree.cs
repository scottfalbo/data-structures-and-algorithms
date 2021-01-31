using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinarySearchTree<T>
    {
        public int counter = 0;
        public Node<T> Root { get; set; } = null;

        public BinarySearchTree() { }

        /// <summary>
        /// Add a new node to the appropriate location in the binary tree
        /// </summary>
        public void Add()
        {
            
        }

        /// <summary>
        /// Takes in a value and return true : false if it's in the tree object
        /// </summary>
        /// <param name="value"></param>
        /// <returns> true : false </returns>
        public bool Contains(T value)
        {
            return true;
        }
    }
}

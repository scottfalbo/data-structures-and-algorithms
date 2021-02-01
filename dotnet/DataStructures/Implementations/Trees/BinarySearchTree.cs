using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
        // Internal counter to track how many Nodes the Tree is holding
        public int counter = 0;
        public BinarySearchTree() { }

        /// <summary>
        /// Add a node to appopriate space in the BinarySearchTree object
        /// </summary>
        /// <param name="root"> treeObject.Root </param>
        /// <param name="value"> value to insert </param>
        public void Add(Node<T> root, T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (Root == null)
            {
                Root = newNode;
                counter++;
                return;
            }

            if (newNode.Value.CompareTo(root.Value) < 0)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                    counter++;
                }
                else
                    Add(root.Left, value);
            }
            else if (newNode.Value.CompareTo(root.Value) > 0)
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                    counter++;
                }
                else
                    Add(root.Right, value);
            }
        }


        public bool Contains(T value)
        {
            Node<T> node = Root;

            while (node != null)
            {
                if (node.Value.Equals(value))
                    return true;
                else if (node.Value.CompareTo(value) > 0)
                    node = node.Left;
                else 
                    node = node.Right; 
            }

            return false;
        }
    }
}

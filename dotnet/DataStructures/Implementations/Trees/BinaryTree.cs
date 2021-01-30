using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    class BinaryTree<T>
    {
        public int counter = 0;
        public Node<T> Root { get; set; } = null;

        public BinaryTree() { }

        /// <summary>
        /// Transverse a binary tree object root -> left -> right
        /// Usage: var myValues[] = myTree.PreOrder();
        /// </summary>
        /// <returns> Array of values in the tree object </returns>
        public T[] PreOrder()
        {
            return new T[] { };
        }

        /// <summary>
        /// Transverse a binary tree object left -> root -> right
        /// Usage: var myValues[] = myTree.InOrder();
        /// </summary>
        /// <returns> Array of values in the tree object </returns>
        public T[] InOrder()
        {
            return new T[] { };
        }

        /// <summary>
        /// Transverse a binary tree object left -> right -> root
        /// Usage: var myValues[] = myTree.PostOrder();
        /// </summary>
        /// <returns> Array of values in the tree object </returns>
        public T[] PostOrder()
        {
            return new T[] { };
        }

    }
}

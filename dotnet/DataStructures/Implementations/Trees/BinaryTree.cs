using System;
using DataStructures;
using System.Text;

namespace DataStructures.Trees
{
    public class BinaryTree<T>
    {
        public int counter = 0;
        public Node<T> Root { get; set; } = null;

        
        public BinaryTree() { }

        /// <summary>
        /// Transverse a binary tree object root -> left -> right
        /// Usage: var myValues[] = myTree.PreOrder();
        /// </summary>
        /// <returns> Array of values in the tree object </returns>
        public T[] PreOrder(Node<T> root)
        {
            LinkedList<T> treeValues = new LinkedList<T>();
            PreOrder(treeValues, root);

            return QueueToArray(treeValues);
        }
        private void PreOrder(LinkedList<T> treeValues, Node<T> root)
        {
            treeValues.Append(root.Value);

            if (root.Left != null)
                PreOrder(treeValues, root.Left);

            if (root.Right != null)
                PreOrder(treeValues, root.Right);
        }
 

        /// <summary>
        /// Transverse a binary tree object left -> root -> right
        /// Usage: var myValues[] = myTree.InOrder();
        /// </summary>
        /// <returns> Array of values in the tree object </returns>
        public T[] InOrder(Node<T> root)
        {
            LinkedList<T> treeValues = new LinkedList<T>();
            InOrder(treeValues, root);

            return QueueToArray(treeValues);
        }
        private void InOrder(LinkedList<T> treeValues, Node<T> root)
        {
            if (root.Left != null)
                InOrder(treeValues, root.Left);

            treeValues.Append(root.Value);

            if (root.Right != null)
                InOrder(treeValues, root.Right);
        }

        /// <summary>
        /// Transverse a binary tree object left -> right -> root
        /// Usage: var myValues[] = myTree.PostOrder();
        /// </summary>
        /// <returns> Array of values in the tree object </returns>
        public T[] PostOrder(Node<T> root)
        {
            LinkedList<T> treeValues = new LinkedList<T>();
            PostOrder(treeValues, root);

            return QueueToArray(treeValues);
        }
        private void PostOrder(LinkedList<T> treeValues, Node<T> root)
        {
            if (root.Left != null)
                PostOrder(treeValues, root.Left);

            if (root.Right != null)
                PostOrder(treeValues, root.Right);

            treeValues.Append(root.Value);
        }

        /// <summary>
        /// Helper Method to convert a LinkedList into an Array for return
        /// </summary>
        /// <param name="treeValues"> LinkedList object of tree values </param>
        /// <returns> Array of tree values </returns>
        public T[] QueueToArray(LinkedList<T> treeValues)
        {
            T[] treeArray = new T[treeValues.counter];
            DataStructures.Node<T> current = treeValues.Head;
            int index = 0;
            while (current != null)
            {
                treeArray[index] = current.Value;
                index++;
                current = current.Next;
            }
            return treeArray;
        }
    }
}

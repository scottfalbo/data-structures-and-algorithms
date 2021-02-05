using System;
using DataStructures;
using System.Text;
using System.Collections.Generic;

namespace DataStructures.Trees
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; } = null;

        public BinaryTree() { }

        /// <summary>
        /// Transverse a binary tree object root -> left -> right
        /// Usage: var myValues[] = myTree.PreOrder();
        /// </summary>
        /// <returns> Array of values in the tree object </returns>
        public T[] PreOrder()
        {
            LinkedList<T> treeValues = new LinkedList<T>();
            Node<T> root = Root;
            try
            {
                PreOrder(treeValues, root);
            }
            catch(ArgumentException e)
            {
                throw new NullReferenceException($"womp womp, {e}");
            }


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
        public T[] InOrder()
        {
            LinkedList<T> treeValues = new LinkedList<T>();
            Node<T> root = Root;
            try
            {
                InOrder(treeValues, root);
            }
            catch (ArgumentException e)
            {
                throw new NullReferenceException($"womp womp, {e}");
            }

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
        public T[] PostOrder()
        {
            LinkedList<T> treeValues = new LinkedList<T>();
            Node<T> root = Root;
            try
            {
                PostOrder(treeValues, root);
            }
            catch (ArgumentException e)
            {
                throw new NullReferenceException($"womp womp, {e}");
            }

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
        /// Recursively search a Binary Tree object for the largest number.
        /// Tracks and compares each value against the last always storing the largest.
        /// myTree.FindMaxValue(myTree.Root);
        /// </summary>
        /// <param name="root"> Node<int> </int>treeObject.Root </param>
        /// <returns> int largest value </returns>
        public int FindMaxValue(Node<int> root)
        {
            if (root == null)
                return 0;

            int maxValue = root.Value;
            int leftValue = FindMaxValue(root.Left);
            int rightValue = FindMaxValue(root.Right);

            if (leftValue > maxValue)
                maxValue = leftValue;

            if (rightValue > maxValue)
                maxValue = rightValue;

            return maxValue;
        }

        /// <summary>
        /// Breadth first transversal of a binary tree
        /// </summary>
        /// <returns> List of node values </returns>
        public List<T> BreadthFirst()
        {
            List<T> treeValues = new List<T>();
            Queue<Node<T>> holder = new Queue<Node<T>>();
            Node<T> node = Root;

            holder.Enqueue(node);

            while (!holder.IsEmpty())
            {
                node = holder.Dequeue();
                treeValues.Add(node.Value);

                if (node.Left != null)
                    holder.Enqueue(node.Left);

                if (node.Right != null)
                    holder.Enqueue(node.Right);
            }
            return treeValues;
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

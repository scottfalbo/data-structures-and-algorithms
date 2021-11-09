using System;
using System.Text;
using DataStructures.Trees;
using DataStructures;

namespace Practice
{
    public class BinaryTreePractice
    {
        /// <summary>
        /// Find the total value of all node values in a BinaryTree<int>
        /// </summary>
        /// <param name="tree"> BinaryTree<int> object </param>
        /// <returns> int total value </returns>
        public static int FindValue(BinaryTree<int> tree)
        {
            int total = 0;

            Queue<DataStructures.Trees.Node<int>> queue = new Queue<DataStructures.Trees.Node<int>>();
            queue.Enqueue(tree.Root);

            while (queue.Front != null)
            {
                DataStructures.Trees.Node<int> current = queue.Dequeue();
                total += current.Value;
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            return total;
        }
    }
}

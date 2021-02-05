using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class KAryTree<T>
    {
        public int Max { get; set; }
        public KNode<T> Root { get; set; }

        /// <summary>
        /// Constructor to set max amount of children a node may have
        /// </summary>
        /// <param name="maxChildren"> int, max children for node </param>
        public KAryTree(int maxChildren)
        {
            Max = maxChildren;
        }

        /// <summary>
        /// PreOrder traversal
        /// </summary>
        /// <returns> List of node values </returns>
        public List<T> PreOrder()
        {
            List<T> treeValues = new List<T>();
            KNode<T> root = Root;
            try
            {
                PreOrder(treeValues, root);
            }
            catch (ArgumentException e)
            {
                throw new NullReferenceException($"womp womp, {e}");
            }
            return treeValues;
        }
        private void PreOrder(List<T> treeValues, KNode<T> root)
        {
            treeValues.Add(root.Value);

            if (root.Children != null)
            {
                foreach (var child in root.Children)
                    PreOrder(treeValues, child);
            }

        }



        /// <summary>
        /// Breadth First traversal
        /// </summary>
        /// <returns> List of node values </returns>
        public List<T> BreadthFirst()
        {
            List<T> treeValues = new List<T>();
            Queue<KNode<T>> holder = new Queue<KNode<T>>();
            KNode<T> node = Root;

            holder.Enqueue(node);

            while (!holder.IsEmpty())
            {
                node = holder.Dequeue();
                treeValues.Add(node.Value);

                if (node.Children != null)
                {
                    foreach (var child in node.Children)
                        holder.Enqueue(child);
                }

            }
            return treeValues;
        }
    }
}

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


        public List<T> BreadthFirst()
        {
            List<T> treeValues = new List<T>();
            Queue<KNode<T>> holder = new Queue<KNode<T>>();
            KNode<T> node = Root;

            holder.Enqueue(node);

            while (holder.counter > 0)
            {
                node = holder.Dequeue();
                treeValues.Add(node.Value);

                List<KNode<T>> children = node.Children;

                if (children.Count > 0)
                {
                    foreach (var child in children)
                        holder.Enqueue(child);
                }

            }
            return treeValues;
        }
    }
}

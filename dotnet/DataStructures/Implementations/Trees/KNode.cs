using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class KNode<T>
    {
        public T Value { get; set; }
        public List<KNode<T>> Children { get; set; }
        
        public KNode() { Children = new List<KNode<T>>(); }

        /// <summary>
        /// Constructor to that sets the nodes value on instantiation
        /// </summary>
        /// <param name="value"> T value </param>
        public KNode(T value)
        {
            Value = value;
            Children = new List<KNode<T>>();
        }

        /// <summary>
        /// Constructor to set value and children on instantiation
        /// </summary>
        /// <param name="value"> T value </param>
        /// <param name="children"> T value List of children </param>
        public KNode(T value, List<KNode<T>> children)
        {
            Value = value;
            Children = children;
        }
        
    }
}

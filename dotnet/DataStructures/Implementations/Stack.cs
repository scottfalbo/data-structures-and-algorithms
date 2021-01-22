using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stacks<T>
    {
        public Node<T> Top { get; set; }

        /// <summary>
        /// Return the Value of the top node
        /// </summary>
        /// <returns></returns>
        public T Peek() => Top.Value;

        /// <summary>
        /// Returns true if the Stack object is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Top == null;

        /// <summary>
        /// Puts a new Node onto the Stack object
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Returns and removes the Top Node object from the Stack object
        /// </summary>
        /// <returns></returns>
        public Node<T> Pop()
        {
            Node<T> holder = Top;
            Top = holder.Next;
            holder.Next = null;
            return holder;
        }
    }



}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue<T>
    {
        public Node<T> Front { get; set; }

        public Node<T> Rear { get; set; }

        /// <summary>
        /// Add a Node object to the Queue object and attatch to to the end of the line
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Returns the Value of the First object in the Queue object and then removes it
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            Node<T> holder = Front;
            Front = Front.Next;
            holder.Next = null;
            return holder.Value;
        }

        /// <summary>
        /// Returns the Value of the Front Node in the Queue object
        /// </summary>
        /// <returns></returns>
        public T Peek() => Front.Value;

        /// <summary>
        /// Returns true if the Queue object is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Front == null;
    }
}

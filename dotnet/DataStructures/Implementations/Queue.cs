using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queue<T>
    {
        public int counter = 0;
        public Node<T> Front { get; set; } = null;
        public Node<T> Rear { get; set; } = null;

        /// <summary>
        /// Returns the Value of the Front Node in the Queue object
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            try
            {
                return Front.Value;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException($"{e}");
            }
        }

        /// <summary>
        /// Returns true if the Queue object is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Front == null;

        /// <summary>
        /// Add a Node object to the Queue object and attatch to to the end of the line
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                node.Next = Rear;
                Rear = node;
            }
            counter++;
        }

        /// <summary>
        /// Returns the Value of the First object in the Queue object and then removes it
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            try
            {
                Node<T> holder = Front;
                Front = Front.Next;
                holder.Next = null;
                counter--;
                return holder.Value;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException($"{e}");
            }
        }

    }
}

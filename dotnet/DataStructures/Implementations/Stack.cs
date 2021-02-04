using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T>
    {
        public int counter = 0;
        public Node<T> Top { get; set; } = null;

        /// <summary>
        /// Return the Value of the top node
        /// throws null reference exception if the object is empty.
        /// </summary>
        /// <returns></returns>
        public T Peek() 
        {
            try
            {
                return Top.Value;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException($"{e}");
            }
        }

        /// <summary>
        /// Returns true if the Stack object is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => Top == null;

        /// <summary>
        /// Puts a new Node onto the Stack object, adds to stack count
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value)
            {
                Next = Top
            };
            Top = node;
            counter++;
        }

        /// <summary>
        /// Returns and removes the Top Node object from the Stack object, decrements stack count
        /// throws null reference exception if the object is empty.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            try
            {
                Node<T> holder = Top;
                Top = holder.Next;
                holder.Next = null;
                counter--;
                return holder.Value;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException($"Your stack is empty, {e}");
            }                
        }

    }

}

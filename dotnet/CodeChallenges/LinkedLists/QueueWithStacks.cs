using System;
using System.Text;
using DataStructures;

namespace Challenges
{
    public class QueueWithStacks<T>
    {
        public Stack<T> Stack1 { get; set; }
        public Stack<T> Stack2 { get; set; }

        public QueueWithStacks() 
        {
            Stack1 = new Stack<T>();
            Stack2 = new Stack<T>();
        }

        /// <summary>
        /// Mimic a Queue object's enqueue method with stacks,
        /// and returns the value what would be the front object
        /// </summary>
        /// <param name="value"> value to enqueue </param>
        /// <returns></returns>
        public T Enqueue(T value)
        {
            Stack1.Push(value);
            while (!Stack1.IsEmpty())
                Stack2.Push(Stack1.Pop());

            T frontValue = Stack2.Peek();

            while (!Stack2.IsEmpty())
                Stack1.Push(Stack2.Pop());

            return frontValue;
        }

        /// <summary>
        /// Mimic a Queue object's dequeue method with stacks.
        /// Pop() what would be the front node and return the value
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            try
            {
                while (!Stack1.IsEmpty())
                    Stack2.Push(Stack1.Pop());

                T frontValue = Stack2.Pop();

                while (!Stack2.IsEmpty())
                    Stack1.Push(Stack2.Pop());

                return frontValue;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException($"Your stack is empty, womp womp\n{e}");
            }
        }
    }
}

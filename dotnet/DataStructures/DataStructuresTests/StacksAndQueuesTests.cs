using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
    public class StacksAndQueuesTests
    {
        [Fact]
        public void Can_Successfully_Push_Into_A_Stack()
        {
            Stack<int> testStack = new Stack<int>();
            testStack.Push(3);
            bool isEmpty = testStack.IsEmpty();
            Assert.False(isEmpty);
        }

        [Fact]
        public void Can_Successfully_Push_Mulitple_Values_Into_A_Stack()
        {
            Stack<int>testStack = PopulateStack();
            int stackLength = testStack.counter;
            Assert.Equal(5, stackLength);
        }

        [Fact]
        public void Can_Successfully_Pop_Off_Of_A_Stack()
        {
            Stack<int> testStack = PopulateStack();
            testStack.Pop();
            int stackLength = testStack.counter;
            Assert.Equal(4, stackLength);
        }

        [Fact]
        public void Can_Successfully_Empty_A_Stack_After_Multiple_Pops()
        {
            Stack<int> testStack = PopulateStack();
            while (!testStack.IsEmpty())
                testStack.Pop();
            Assert.True(testStack.IsEmpty());
        }

        [Fact]
        public void Can_Peek_Next_Node_Value_On_The_Stack()
        {
            Stack<int> testStack = PopulateStack();
            int result = testStack.Peek();
            Assert.Equal(5, result);
        }

        [Fact]
        public void Can_Instantiate_An_Empty_Stack()
        {
            Stack<int> newStack = new Stack<int>();
            bool isEmpty = newStack.IsEmpty();
            Assert.True(isEmpty);
        }

        [Fact]
        public void Calling_Pop_On_Empty_Stack_Raises_Exception()
        {
            Stack<int> testStack = new Stack<int>();
            Assert.Throws<NullReferenceException>(() => testStack.Pop());
        }

        [Fact]
        public void Calling_Peek_On_Empty_Stack_Raises_Exception()
        {
            Stack<int> testStack = new Stack<int>();
            Assert.Throws<NullReferenceException>(() => testStack.Peek());
        }

        [Fact]
        public void Can_Successfully_Enqueue_Into_A_Queue()
        {
            Queue<string> testQueue = new Queue<string>();
            testQueue.Enqueue("In we go!");
            Assert.Equal(1, testQueue.counter);
        }

        [Fact]
        public void Can_Successfully_Enqueue_Multiple_Values_Into_A_Queue()
        {
            Queue<string> testQueue = PopulateQueue();
            Assert.Equal(5, testQueue.counter);
        }

        [Fact]
        public void Can_Successfullt_Dequeue_The_Expected_Value()
        {
            Queue<string> testQueue = PopulateQueue();
            string testString = testQueue.Dequeue();
            Assert.Equal("Thing 1", testString);
        }

        [Fact]
        public void Can_Successfully_Peek_The_Front_Value_Of_A_Queue()
        {
            Queue<string> testQueue = PopulateQueue();
            string testString = testQueue.Peek();
            Assert.Equal("Thing 1", testString);
        }

        [Fact]
        public void Can_Successfully_Empty_A_Queue_After_Multiple_Dequeues()
        {
            Queue<string> testQueue = PopulateQueue();
            while (!testQueue.IsEmpty())
                testQueue.Dequeue();
            Assert.True(testQueue.IsEmpty());
        }

        [Fact]
        public void Can_Successfully_Instantiate_An_Empty_Queue()
        {
            Queue<string> testQueue = (new Queue<string>());
            Assert.True(testQueue.IsEmpty());
        }

        [Fact]
        public void Calling_Dequeue_On_Empty_Queue_Raises_Exception()
        {
            Queue<string> testQueue = (new Queue<string>());
            Assert.Throws<NullReferenceException>(() => testQueue.Dequeue());
        }

        [Fact]
        public void Calling_Peek_On_Empty_Queue_Raises_Exception()
        {
            Queue<string> testQueue = (new Queue<string>());
            Assert.Throws<NullReferenceException>(() => testQueue.Peek());
        }

        /// <summary>
        /// Helper method to instantiate, populate and return a Queue object
        /// </summary>
        /// <returns></returns>
        public Queue<string> PopulateQueue()
        {
            Queue<string> newQueue = (new Queue<string>());
            newQueue.Enqueue("Thing 1");
            newQueue.Enqueue("Thing 2");
            newQueue.Enqueue("Thing 3");
            newQueue.Enqueue("Thing 4");
            newQueue.Enqueue("Thing 5");
            return newQueue;
        }

        /// <summary>
        /// Helper method to instantiate, populate and return a Stack object
        /// </summary>
        /// <returns></returns>
        public Stack<int> PopulateStack()
        {
            Stack<int> newStack = new Stack<int>();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.Push(5);
            return newStack;
        }

    }
}

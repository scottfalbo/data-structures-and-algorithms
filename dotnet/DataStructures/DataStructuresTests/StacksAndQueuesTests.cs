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
            bool isEmpty = testStack.IsEmpty();
            Assert.True(isEmpty);
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
            Stack<int> newStack = new Stack<int>();
            Assert.Throws<NullReferenceException>(() => newStack.Pop());
        }

        [Fact]
        public void Calling_Peek_On_Empty_Stack_Raises_Exception()
        {
            Stack<int> newStack = new Stack<int>();
            Assert.Throws<NullReferenceException>(() => newStack.Peek());
        }

        

        /// <summary>
        /// Helper method to make and populate a stack
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

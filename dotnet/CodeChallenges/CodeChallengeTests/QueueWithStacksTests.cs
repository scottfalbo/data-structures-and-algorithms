using System;
using Xunit;
using Challenges;
using DataStructures;

namespace CodeChallengeTests
{
    public class QueueWithStacksTests
    {
        [Fact]
        public void The_Stack_Methods_Are_Working_Inside_The_QueueWithStack_Object()
        {
            QueueWithStacks<int> testQueueStack = new QueueWithStacks<int>();
            testQueueStack.Stack1.Push(1);
            testQueueStack.Stack1.Push(2);
            testQueueStack.Stack1.Push(3);
            testQueueStack.Stack1.Push(4);
            testQueueStack.Stack1.Push(5);
            int result = testQueueStack.Stack1.Pop();
            Assert.Equal(5, result);
        }

        [Fact]
        public void Can_Enequeue_Multiple_Nodes()
        {
            QueueWithStacks<int> testQueueStack = new QueueWithStacks<int>();
            testQueueStack.Enqueue(1);
            testQueueStack.Enqueue(2);
            testQueueStack.Enqueue(3);
            testQueueStack.Enqueue(4);
            testQueueStack.Enqueue(5);
            int result =  testQueueStack.Stack1.Peek();
            Assert.Equal(5, result);
        }

        [Fact]
        public void Can_Enequeue_Multiple_Nodes_And_Dequeue_What_Would_Be_The_Front_Nodes_Value()
        {
            QueueWithStacks<int> testQueueStack = new QueueWithStacks<int>();
            testQueueStack.Enqueue(1);
            testQueueStack.Enqueue(2);
            testQueueStack.Enqueue(3);
            testQueueStack.Enqueue(4);
            testQueueStack.Enqueue(5);
            int result = testQueueStack.Dequeue();
            Assert.Equal(1, result);
        }

        [Fact]
        public void Throw_An_Exception_When_Dequeue_Is_Called_On_Empty_QueueWithStack_Object()
        {
            QueueWithStacks<int> testQueueStack = new QueueWithStacks<int>();
            Assert.Throws<NullReferenceException>(() => testQueueStack.Dequeue());
        }
    }
}

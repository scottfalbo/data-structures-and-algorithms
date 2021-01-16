using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
    public class LinkedListTests
    {
        /// <summary>
        /// Test to unsure our LinkedList class is returning a Head
        /// </summary>
        [Fact]
        public void Linked_List_Created_With_A_Value_Has_A_Head()
        {
            int value = 2;
            LinkedList testList = new LinkedList(value);
            Assert.Equal(value, testList.Head.Value);
        }

        /// <summary>
        /// Make sure that when we insert a node it is the new Head
        /// </summary>
        [Fact]
        public void After_Insert_New_Node_Is_the_Head()
        {
            LinkedList testList = new LinkedList(9);
            testList.Insert(9);
            Assert.Equal(9, testList.Head.Value);
        }

        /// <summary>
        /// Checks to make sure when we insert, that the new Head is pointing to the old Head
        /// </summary>
        [Fact]
        public void After_insert_The_New_Head_Next_Is_Old_Head()
        {
            LinkedList testList = new LinkedList(3);
            Node oldHead = testList.Head;
            testList.Insert(9);
            Assert.Equal(oldHead, testList.Head.Next);
        }
    }
}

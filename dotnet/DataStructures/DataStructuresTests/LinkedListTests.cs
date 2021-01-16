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

        /// <summary>
        /// Given an empty parameter can LinkedList isntantiate an empty object by default
        /// </summary>
        [Fact]
        public void Can_Successfully_Instantiate_An_Empty_Linked_List()
        {
            LinkedList testList = new LinkedList();
            Assert.Null(testList.Head);
        }

        /// <summary>
        /// Make sure Include() returns true if the value is in the list
        /// </summary>
        [Fact]
        public void Check_For_Value_In_Linked_List_True()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(9);
            bool result = testList.Includes(9);
            Assert.True(result);
        }

        /// <summary>
        /// Make sure Include() returns false if the value is not in the list
        /// </summary>
        [Fact]
        public void Check_For_Value_In_Linked_List_False()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(3);
            bool result = testList.Includes(6);
            Assert.False(result);
        }

        /// <summary>
        /// Ensure that multiple nodes can be added to the list.
        /// Popluate a list, iternate over tracking length, verify length after insertion
        /// </summary>
        [Fact]
        public void Properly_Insert_Multiple_Nodes_Into_A_Linked_List()
        {
            // create and linked list and insert 4 nodes
            LinkedList testList = new LinkedList();
            testList.Insert(1);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(4);

            Node current = testList.Head;
            int lengthTracker = 0;

            //iterare over linked list and track length
            while (current != null)
            {
                lengthTracker++;
                current = current.Next;
            }

            Assert.Equal(4, lengthTracker);
        }


        [Fact]
        public void Properly_Return_A_Colletion_Of_All_Values()
        {
            // create and linked list and insert 4 nodes
            LinkedList testList = new LinkedList();
            testList.Insert(1);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(4);

            string expected = "[4] => [3] => [2] => [1] => Null";
            string result = testList.ToString();

            Assert.Equal(expected, result);
        }
    }
}

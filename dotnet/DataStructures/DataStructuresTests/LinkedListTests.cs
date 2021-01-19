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

        // Helper method to populate a generic linked list for the following tests
        public LinkedList PopulateList(LinkedList list)
        {
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            return list;
        }

        [Fact]
        public void Properly_Return_A_Colletion_Of_All_Values()
        {
            LinkedList testList = PopulateList(new LinkedList());

            string expected = "[4] => [3] => [2] => [1] => Null";
            string result = testList.ToString();

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Test to ensure that .Append() can properly append a new node to the end of a list
        /// </summary>
        [Fact]
        public void Append_Node_To_End_Of_The_List()
        {
            LinkedList testList = PopulateList(new LinkedList());

            testList.Append(5);
            Node current = testList.Head;
            int result = 0;

            while(current != null)
            {
                if (current.Next == null)
                    result = current.Value;
                current = current.Next;
            }

            Assert.Equal(5, result);
        }

        /// <summary>
        /// Ensure multiple nodes can be Appended to a list by adding a dynamic amount of nodes,
        /// and then tracking the length of the list.
        /// </summary>
        /// <param name="numberOfNodesToAdd"></param>
        [Theory]
        [InlineData(4)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(20)]
        [InlineData(2)]
        public void Append_Multiple_Values_To_The_End_Of_A_List(int numberOfNodesToAdd)
        {
            // instantiate a new list 4 nodes long
            LinkedList testList = PopulateList(new LinkedList());
            Node current = testList.Head;

            // append numberOfNodesToAdd amount of nodes to the list
            for (int i = 0; i < numberOfNodesToAdd; i++)
                testList.Append(i);

            // iterate over and track length of the new list
            int listLength = 0;
            while (current != null)
            {
                listLength++;
                current = current.Next;
            }
                
            Assert.Equal(numberOfNodesToAdd + 4, listLength);
        }

        /// <summary>
        /// Make sure a node can be inserted before the first node in the list
        /// </summary>
        /// <param name="target"></param>
        /// <param name="insert"></param>
        [Theory]
        [InlineData(2, 9)]
        [InlineData(1, 35)]
        [InlineData(27, 3)]
        public void Insert_A_Node_Before_The_First_Node(int target, int insert)
        {
            LinkedList testList = new LinkedList(target);
            testList.InsertBefore(target, insert);

            Node result = testList.Head;
            Assert.Equal(insert, result.Value);
        }

        // Helper method to find the middle of a linked list
        public int FindTheMiddle(LinkedList list)
        {
            Node current = list.Head;

            int lengthCounter = 0;
            while (current != null)
            {
                lengthCounter++;
                current = current.Next;
            }

            return lengthCounter / 2;
        }

        /// <summary>
        /// Finds the middle of a linked list and inserts a new value.
        /// Then iterates to the middle again and checks the against the value inserted
        /// </summary>
        [Fact]
        public void Can_Insert_Node_Into_Middle_Of_List()
        {
            // populate a linked list with the above helper method
            LinkedList testList = PopulateList(new LinkedList());
            Node current = testList.Head;

            // use the above helper method to find the middle of the array and,
            // add 1 to offset the floor and get behind the center node
            int middle = (FindTheMiddle(testList)) + 1;

            // iterate the the middle and get the value of the node 
            int counter = 0;
            while (counter < middle)
            {
                counter++;
                current = current.Next;
            }
            int targetValue = current.Value;

            // call insert method, reset current node and counter,
            // and iterate to the middle again to check the new value
            testList.InsertBefore(targetValue, 66);
            counter = 0;
            current = testList.Head;
            int middleValue = 0;
            while (counter < middle) 
            {
                counter++;
                current = current.Next;
            }
            if (current.Value == 66) middleValue = current.Value;

            Assert.Equal(66, middleValue);
        }
    }
}


//Can successfully insert after a node in the middle of the linked list
//Can successfully insert a node after the last node of the linked list
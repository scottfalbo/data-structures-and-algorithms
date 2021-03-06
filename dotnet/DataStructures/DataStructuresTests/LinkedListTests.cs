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
            LinkedList<int> testList = new LinkedList<int>(value);
            Assert.Equal(value, testList.Head.Value);
        }

        /// <summary>
        /// Make sure that when we insert a node it is the new Head
        /// </summary>
        [Fact]
        public void After_Insert_New_Node_Is_the_Head()
        {
            LinkedList<int> testList = new LinkedList<int>(9);
            testList.Insert(9);
            Assert.Equal(9, testList.Head.Value);
        }

        /// <summary>
        /// Checks to make sure when we insert, that the new Head is pointing to the old Head
        /// </summary>
        [Fact]
        public void After_insert_The_New_Head_Next_Is_Old_Head()
        {
            LinkedList<int> testList = new LinkedList<int>(3);
            Node<int> oldHead = testList.Head;
            testList.Insert(9);
            Assert.Equal(oldHead, testList.Head.Next);
        }

        /// <summary>
        /// Given an empty parameter can LinkedList isntantiate an empty object by default
        /// </summary>
        [Fact]
        public void Can_Successfully_Instantiate_An_Empty_Linked_List()
        {
            LinkedList<int> testList = new LinkedList<int>();
            Assert.Null(testList.Head);
        }

        /// <summary>
        /// Make sure Include() returns true if the value is in the list
        /// </summary>
        [Fact]
        public void Check_For_Value_In_Linked_List_True()
        {
            LinkedList<int> testList = new LinkedList<int>();
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
            LinkedList<int> testList = new LinkedList<int>();
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
            LinkedList<int> testList = new LinkedList<int>();
            testList.Insert(1);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(4);

            Node<int> current = testList.Head;
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
            LinkedList<int> testList = new LinkedList<int>();
            testList.Append(4);
            testList.Append(3);
            testList.Append(2);
            testList.Append(1);

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
            LinkedList<int> testList = PopulateList(new LinkedList<int>());

            testList.Append(5);
            Node<int> current = testList.Head;
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
            LinkedList<int> testList = PopulateList(new LinkedList<int>());
            Node<int> current = testList.Head;

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
                
            Assert.Equal(numberOfNodesToAdd + 40, listLength);
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
            LinkedList<int> testList = new LinkedList<int>(target);
            testList.InsertBefore(target, insert);

            Node<int> result = testList.Head;
            Assert.Equal(insert, result.Value);
        }

        /// <summary>
        /// Finds the middle of a linked list and inserts a new value before the middle node.
        /// Then iterates to the middle again and checks the against the value inserted
        /// </summary>
        [Fact]
        public void Can_Insert_Node_Before_Middle_Node_Of_List()
        {
            LinkedList<int> testList = PopulateList(new LinkedList<int>());
            Node<int> current = testList.Head;

            int targetValue = FindTheMiddle(testList);

            testList.InsertBefore(targetValue, 66);
            int result = 0;

            while (current != null) 
            {
                if (current.Next.Value == targetValue)
                {
                    result = current.Value;
                    break;
                }
                current = current.Next;
            }

            Assert.Equal(66, result);
        }

        /// <summary>
        /// Make sure that a new node can be inserted after the last node in a list
        /// </summary>
        [Fact]
        public void Can_Insert_Node_After_Last_Node_Of_Linked_List()
        {
            LinkedList<int> testList = PopulateList(new LinkedList<int>());
            Node<int> current = testList.Head;

            testList.InsertAfter(39, 5);
            int lastValue = 0;

            while (current != null)
            {
                if (current.Next == null) lastValue = current.Value;
                current = current.Next;
            }

            Assert.Equal(5, lastValue);
        }

        /// <summary>
        /// Finds the middle of a linked list and inserts a new value after the middle node.
        /// Then iterates to the middle again and checks the against the value inserted
        /// </summary>
        [Fact]
        public void Can_Insert_Node_After_Middle_Node_Of_List()
        {
            LinkedList<int> testList = PopulateList(new LinkedList<int>());
            Node<int> current = testList.Head;

            int targetValue = FindTheMiddle(testList);

            testList.InsertAfter(targetValue, 66);
            int result = 0;

            while (current != null)
            {
                if (current.Value == targetValue)
                {
                    result = current.Next.Value;
                    break;
                }
                current = current.Next;
            }

            Assert.Equal(66, result);
        }

        /// <summary>
        /// Test for case when given an argument greater than the length of the list
        /// </summary>
        [Fact]
        public void K_Is_Greater_Than_Length_Of_List()
        {
            LinkedList<int> testList = PopulateList(new LinkedList<int>());
            int result = testList.KthFromEnd(45);
            Assert.Equal(-1, result);
        }

        /// <summary>
        /// Test for case when argument equals the length of the list
        /// </summary>
        [Fact]
        public void K_Is_Equal_To_The_Length_Of_List()
        {
            LinkedList<int> testList = PopulateList(new LinkedList<int>());
            int result = testList.KthFromEnd(40);
            Assert.Equal(-1, result);
        }

        /// <summary>
        /// Test for negative integer input for k
        /// </summary>
        [Fact]
        public void K_Is_Not_A_Positive_Integer()
        {
            LinkedList<int> testList = PopulateList(new LinkedList<int>());
            int result = testList.KthFromEnd(-6);
            Assert.Equal(-1, result);
        }

        /// <summary>
        /// Edge case where list is only one node long, returns -1 error
        /// </summary>
        [Fact]
        public void List_Is_Only_One_Node_In_Length()
        {
            LinkedList<int> testList = new LinkedList<int>(1);
            int result = testList.KthFromEnd(0);
            Assert.Equal(-1, result);
        }

        /// <summary>
        /// Happy Path with good data
        /// </summary>
        /// <param name="expected">int of expected Node.Value</param>
        /// <param name="k">int argument for search</param>
        [Theory]
        [InlineData(34, 5)]
        [InlineData(24, 15)]
        [InlineData(20, 19)]
        [InlineData(31, 8)]
        [InlineData(0, 39)]
        public void Happy_Path_Finds_The_Right_Value_All_Is_Well(int expected, int k)
        {
            LinkedList<int> testList = PopulateList(new LinkedList<int>());
            int result = testList.KthFromEnd(k);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_Delete_A_Node_And_Keep_The_Rest_Of_List()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList = PopulateList(testList);
            testList.RemoveNode(24);
            testList.RemoveNode(2);
            testList.RemoveNode(35);
            testList.RemoveNode(6);
            int actual = testList.counter;
            int expected = 36;
            Assert.Equal(expected, actual);
        }

        // Helper method to populate a generic linked list for the following tests
        public LinkedList<int> PopulateList(LinkedList<int> list)
        {
            for (int i = 0; i < 40; i++)
                list.Append(i);
            return list;
        }

        // Helper method to find the middle value of a linked list
        public int FindTheMiddle(LinkedList<int> list)
        {
            Node<int> current = list.Head;

            // Iterate the length of the list and half the counter
            int lengthCounter = 0;
            while (current != null)
            {
                lengthCounter++;
                current = current.Next;
            }

            // iterate the the middle and get the value of the node 
            int counter = 0;
            current = list.Head;
            while (counter < (lengthCounter / 2) + 1)
            {
                counter++;
                current = current.Next;
            }
            // return the value of the middle node 
            return current.Value;
        }


    }
}


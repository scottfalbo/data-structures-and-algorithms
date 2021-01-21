using System;
using Xunit;
using static LinkedLists.Program;
using LLZip;
using DataStructures;

namespace CodeChallengeTests
{
    public class LinkedListTests
    {
      /// <summary>
      /// Activity test, return true or false that it did something
      /// </summary>
      [Fact]
      public void Linked_List_Activity_Test()
        {
            bool itWorks = LinkListActivity();
            Assert.True(itWorks);
        }

        [Fact]
        public void Zip_List_Happy_Paths_Returning_As_Expected_Even_Length_Lists()
        {
            LinkedList listA = new LinkedList();
            listA.Append(1);
            listA.Append(3);
            listA.Append(5);

            LinkedList listB = new LinkedList();
            listA.Append(2);
            listA.Append(4);
            listA.Append(6);

            Node testReference = Program.ZipList(listA, listB);
            LinkedList testList = new LinkedList(testReference);

            string result = testList.ToString();

            string expected = "[1] => [2] => [3] => [4] => [5] => [6] => Null";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Empty_List_Passed_In_As_Argument()
        {
            LinkedList listA = new LinkedList();
            listA.Append(1);

            LinkedList listB = new LinkedList();

            Node testReference = Program.ZipList(listA, listB);

            Assert.Null(testReference);
        }
    }
}

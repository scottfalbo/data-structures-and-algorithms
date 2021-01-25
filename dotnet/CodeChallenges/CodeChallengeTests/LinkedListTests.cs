using System;
using Xunit;
using static LinkedLists.Program;
using LinkedLists;
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
            LinkedList<int> listA = new LinkedList<int>();
            listA.Append(1);
            listA.Append(3);
            listA.Append(5);

            LinkedList<int> listB = new LinkedList<int>();
            listB.Append(2);
            listB.Append(4);
            listB.Append(6);

            Node<int> testListHead = LLZip.ZipList(listA, listB);
            LinkedList<int> testList = new LinkedList<int>(testListHead);

            string result = testList.ToString();

            string expected = "[1] => [2] => [3] => [4] => [5] => [6] => Null";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Zip_List_Can_Combine_Uneven_length_Lists_When_ListA_Is_Longer()
        {
            LinkedList<int> listA = MakeList(6, 0);
            LinkedList<int> listB = MakeList(3, 1);

            Node<int> testListHead = LLZip.ZipList(listA, listB);
            LinkedList<int> testList = new LinkedList<int>(testListHead);

            string result = testList.ToString();

            string expected = "[0] => [1] => [0] => [1] => [0] => [1] => [0] => [0] => [0] => Null";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Zip_List_Can_Combine_Uneven_length_Lists_When_ListB_Is_Longer()
        {
            LinkedList<int> listA = MakeList(3, 0);
            LinkedList<int> listB = MakeList(6, 1);

            Node<int> testListHead = LLZip.ZipList(listA, listB);
            LinkedList<int> testList = new LinkedList<int>(testListHead);

            string result = testList.ToString();

            string expected = "[0] => [1] => [0] => [1] => [0] => [1] => [1] => [1] => [1] => Null";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Empty_Lists_Passed_In_As_Argument()
        {
            LinkedList<int> listA = new LinkedList<int>();
            LinkedList<int> listB = new LinkedList<int>();

            Node<int> testReference = LLZip.ZipList(listA, listB);

            Assert.Null(testReference);
        }

        /// <summary>
        /// Helper method that makes a list n things long and puts in a given value.
        /// </summary>
        /// <param name="len"> int: length of list </param>
        /// <param name="input"> int: input value </param>
        /// <returns></returns>
        public LinkedList<int> MakeList(int len, int input)
        {
            LinkedList<int> newList = new LinkedList<int>();

            for (int i = 0; i < len; i++)
                newList.Append(input);

            return newList;
        }
        
    }
}

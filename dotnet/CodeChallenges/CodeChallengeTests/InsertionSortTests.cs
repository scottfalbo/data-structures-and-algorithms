using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures;
using DataStructures.Trees;
using Challenges;

namespace CodeChallengeTests
{
    public class InsertionSortTests
    {
        [Theory]
        [InlineData(new int[6] { 8, 4, 23, 42, 16, 15 }, new int[6] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new int[6] { 20, 18, 12, 8, 5, -2 }, new int[6] { -2, 5, 8, 12, 18, 20 })]
        [InlineData(new int[6] { 5, 12, 7, 5, 5, 7 }, new int[6] { 5, 5, 5, 7, 7, 12 })]
        [InlineData(new int[6] { 2, 3, 5, 7, 13, 11 }, new int[6] { 2, 3, 5, 7, 11, 13 })]
        public void Can_Properly_Sort_An_Array(int[] testArr, int[] expected)
        {
            InsertionSort.Sort(testArr);
            Assert.Equal(testArr, expected);
        }

    }
}

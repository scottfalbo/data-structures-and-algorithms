using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 15, 2)]
        [InlineData(new int[] { 11, 22, 33, 44, 55, 66, 77 }, 99, -1)]
        [InlineData(new int[] { 1, 2, 3, 5, 6, 7 }, 4, -1)]
        public void HappyPath(int[] testArray, int testValue, int expected)
        {

        }
    }
}

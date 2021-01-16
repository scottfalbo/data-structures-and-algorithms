using System;
using Xunit;
using ArrayShift;

namespace ArrayShiftTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, new int[] { 4, 8, 15, 23, 42 }, 16)]
        [InlineData(new int[] { 2, 4, 5, 6, 8 }, new int[] { 2, 4, 6, 8 }, 5)]
        [InlineData(new int[] { 5, 4, 3, 2, 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 2, 3, 4, 5 }, 1)]
        public void HappyPath(int[] expected, int[] testInput, int value)
        {
            int[] result = Program.InsertShiftArray(testInput, value);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ArrayTooSmall()
        {
            int[] expected = new int[0];
            int[] testInput = new int[] { 3 };
            int[] result = Program.InsertShiftArray(testInput, 1);
            Assert.Equal(expected, result);
        }
    }
}

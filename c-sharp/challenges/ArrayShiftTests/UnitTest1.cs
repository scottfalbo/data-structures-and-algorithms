using System;
using Xunit;
using ArrayShift;

namespace ArrayShiftTests
{
    public class UnitTest1
    {
        [Fact]
        public void HappyPath()
        {
            int[] expected = new int[] { 4, 8, 15, 16, 23, 42 };
            int[] testInput = new int[] { 4, 8, 15, 23, 42 };
            int[] result = Program.InsertShiftArray(testInput, 16);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ArrayTooSmall()
        {
            int[] expected = new int[] { 3 };
            int[] testInput = new int[] { 3 };
            int[] result = Program.InsertShiftArray(testInput, 1);
            Assert.Equal(expected, result);
        }
    }
}

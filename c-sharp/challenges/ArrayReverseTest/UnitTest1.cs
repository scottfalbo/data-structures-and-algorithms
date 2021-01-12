using System;
using Xunit;
using ArrayReverse;

namespace ArrayReverseTest
{
    public class UnitTest1
    {
        [Fact] // annotation, this is a test that is a matter of fact
        public void ReturnReverseArray()
        {
            //Assmebly, set up test data
            int[] testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Act on that data, run the code
            int[] result = Program.ReverseArray(testArray);

            // Assertions, did it work
            Assert.Equal(new int[] {8, 7, 6, 5, 4, 3, 2, 1 }, result);
        }
    }
}

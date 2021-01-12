using System;

namespace ArrayReverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            // method built for testing

            Console.WriteLine("[{0}]", string.Join(", ", ReverseArray(new int[]{2})));
        }
 
        /// <summary>
        /// Return an array in reverse order of input array.
        /// If array.length < 3 throw exception
        /// </summary>
        /// <param name="arr">
        /// array to be reversed
        /// </param>
        /// <returns>
        /// reversed arr parameter
        /// </returns>
        public static int[] ReverseArray(int[] arr)
        {
            if (arr.Length < 3)
                throw new Exception("Array is not long enough");
            else
            {
                int start = 0;
                int end = arr.Length - 1;

                while (end > start)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }
                return arr;
            }
        }
    }
}

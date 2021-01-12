using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = new int[] { 89, 2354, 3546, 23, 10, -923, 823, -12 };
            int[] arr3 = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 };

            Console.WriteLine("[{0}]", string.Join(", ", ReverseArray(arr)));
            Console.WriteLine("[{0}]", string.Join(", ", ReverseArray(arr2)));
            Console.WriteLine("[{0}]", string.Join(", ", ReverseArray(arr3)));
        }
        static int[] ReverseArray(int[] arr)
        {
            if (arr.Length < 3)
                throw new Exception("Array is not long enough");

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


using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int SearchArray(int[] arr, int query)
        {
            int start = 0;
            int last = arr.Length - 1;
            int mid = (start + last) / 2;
            do
            {
                if (arr[mid] == query)
                    return mid;
                else if (arr[mid] < query)
                    start = mid + 1;
                else
                    last = mid - 1;
            } while (start !> last);
            return -1;
        }
    }
}

using System;

namespace ArrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            // method to take in an array and value, put value into middle of array
        }
        public static int[] InsertShiftArray(int[] array, int value)
        {
            if (array.Length < 2)
            {
                Console.WriteLine("Array must have more than 1 index.");
                return array;
            }
            else
            {
                int arrLen = array.Length;
                int[] returnArr = new int[arrLen + 1];
                int middleIndex = (arrLen + 1) / 2;

                returnArr[middleIndex] = value;
                for (int n = 0; n < returnArr.Length; n++)
                {
                    if (n < middleIndex)
                        returnArr[n] = array[n];
                    if (n > middleIndex)
                        returnArr[n] = array[n - 1];
                }
                return returnArr;
            }
        }
    }
}

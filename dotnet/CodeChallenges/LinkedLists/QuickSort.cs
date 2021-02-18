using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class QuickSort
    {
        public static void Sort(int[] inputArr, int left, int right)
        {
            if (left < right)
            {
                int i = Partition(inputArr, left, right);
                Sort(inputArr, left, i - 1);
                Sort(inputArr, i + 1, right);
            }
        }

        public static int Partition(int[] inputArr, int left, int right)
        {
            int pivot = inputArr[right];

            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (inputArr[j] < pivot)
                {
                    i++;
                    int holder = inputArr[i];
                    inputArr[i] = inputArr[j];
                    inputArr[j] = holder;
                }
            }

            int holder2 = inputArr[i + 1];
            inputArr[i + 1] = inputArr[right];
            inputArr[right] = holder2;

            return i + 1;
        }
    }
}

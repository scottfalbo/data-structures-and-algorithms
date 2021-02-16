using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class InsertionSort
    {
        /// <summary>
        /// Takes in an array of integers and sorts them, in place, into ascending order by value.
        /// </summary>
        /// <param name="inputArr"> int[] array to be sorted </param>
        public static void Sort(int[] inputArr)
        {
            int len = inputArr.Length;

            for (int i = 1; i < len; i++)
            {
                int j = i - 1;
                int holder = inputArr[i];

                while (j >= 0 && holder < inputArr[j])
                {
                    inputArr[j + 1] = inputArr[j];
                    j--;
                }
                inputArr[j + 1] = holder;
            }
        }
    }
}

using System;
using System.Text;

namespace Challenges.Sorts
{
    public class MergeSort
    {
        /// <summary>
        /// This is the middle man between the test and the actual sorting algorithm
        /// Calls itself recursively to create a call stack
        /// The given array is split up into halves
        /// This happens recursively until there are only two values left to compare and merge
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] MergeSorter(int[] array)
        {
            int arrayLength = array.Length;

            if (arrayLength > 1)
            {
                // ToDo: Account for odd length array
                //       Conditional to handle both situations
                int mid = arrayLength / 2;
                int[] leftSide = new int[mid];
                int[] rightSide = new int[mid];

                for (int i = 0; i < mid; i++)
                {
                    leftSide[i] = array[i];
                }

                for (int i = 0; i < mid; i++)
                {
                    rightSide[i] = array[mid + i];
                }

                MergeSorter(leftSide);
                MergeSorter(rightSide);
                Merge(leftSide, rightSide, array);
            }

            return array;
        }

        /// <summary>
        /// This is where the split up arrays are merged back together,
        /// And is where the magic happens.
        /// Places the proper values in their proper place within the full array that gets returned
        /// </summary>
        /// <param name="leftSide"></param>
        /// <param name="rightSide"></param>
        /// <param name="array"></param>
        public static void Merge(int[] leftSide, int[] rightSide, int[] array)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < leftSide.Length &&
                    j < rightSide.Length)
            {
                if (leftSide[i] <= rightSide[j])
                {
                    array[k] = leftSide[i];
                    i += 1;
                }
                else
                {
                    array[k] = rightSide[j];
                    j += 1;
                }
                k += 1;
            }

            if (i == leftSide.Length)
            {
                while (j < rightSide.Length)
                {
                    array[k] = rightSide[j];
                    j += 1;
                    k += 1;
                }
            }
            else
            {
                while (i < leftSide.Length)
                {
                    array[k] = leftSide[i];
                    i += 1;
                    k += 1;
                }
            }

        }

    }
}

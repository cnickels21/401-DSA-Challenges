using System;
using System.Text;

namespace Challenges.Sorts
{
    public class MergeSort
    {
        public static int[] MergeSorter(int[] array)
        {
            int arrayLength = array.Length;

            if (arrayLength > 1)
            {
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

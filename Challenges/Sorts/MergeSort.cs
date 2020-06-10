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

        //        ALGORITHM Mergesort(arr)
        //    DECLARE n<-- arr.length

        //    if n > 1
        //      DECLARE mid <-- n/2
        //      DECLARE left <-- arr[0...mid]
        //      DECLARE right<-- arr[mid...n]
        //      // sort the left side
        //      Mergesort(left)
        //      // sort the right side
        //      Mergesort(right)
        //      // merge the sorted left and right sides together
        //      Merge(left, right, arr)

        //ALGORITHM Merge(left, right, arr)
        //    DECLARE i<-- 0
        //    DECLARE j<-- 0
        //    DECLARE k<-- 0

        //    while i<left.length && j<right.length
        //        if left[i] <= right[j]
        //            arr[k] <-- left[i]
        //            i<-- i + 1
        //        else
        //            arr[k] <-- right[j]
        //            j<-- j + 1


        //        k<-- k + 1

        //    if i = left.length
        //       set remaining entries in arr to remaining values in right
        //    else
        //       set remaining entries in arr to remaining values in left

    }
}

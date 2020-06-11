using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Sorts
{
    public class SuperQuickSort
    {

        public static int[] QuickSort(int[] array)
        {
            if (array.Length == 0)
                return array;

            return QuickSort(array, 0, array.Length - 1);
        }

        public static int[] QuickSort(int[] array, int left, int right)
        {
            if (array[left] < array[right])
            {
                int position = Partition(array, left, right);

                QuickSort(array, left, position - 1);
                QuickSort(array, position + 1, right);
            }

            return array;
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int lowerThanPivot = left - 1;

            for (int i = 0; i < right; i++)
            {
                if (array[i] <= pivot)
                {
                    lowerThanPivot++;
                    Swap(array, i, lowerThanPivot);
                }
            }

            Swap(array, right, lowerThanPivot + 1);
            return lowerThanPivot + 1;
        }

        private static void Swap(int[] array, int i, int lowerThanPivot)
        {
            int temp = array[i];
            array[i] = array[lowerThanPivot];
            array[lowerThanPivot] = temp;
        }

        //        ALGORITHM Partition(arr, left, right)
        //        // set a pivot value as a point of reference
        //        DEFINE pivot<-- arr[right]
        //        // create a variable to track the largest index of numbers lower than the defined pivot
        //        DEFINE low<-- left - 1
        //        for i<- left to right do
        //            if arr[i] <= pivot
        //                low++
        //              Swap(arr, i, low)

        //        // place the value of the pivot location in the middle.
        //        // all numbers smaller than the pivot are on the left, larger on the right. 
        //        Swap(arr, right, low + 1)
        //        return the pivot index point
        //        return low + 1

        //         ALGORITHM
        //         Swap(arr, i, low)
        //         DEFINE temp;
        //         temp<-- arr[i]

        //         arr[i] <-- arr[low]

        //         arr[low] <-- temp


    }
}

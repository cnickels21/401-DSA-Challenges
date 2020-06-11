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
            if (left < right)
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

            // Why does Matt have i < right - 1; but it still works for him
            // What edge case is being covered by this slight difference?
            for (int i = left; i < right; i++)
            {
                // Matt's code has <= here, I assume to compensate for the -1 in the comment above
                // Between these two minor differences, what is being accomplished?
                // I have added the = now and my tests still pass
                if (array[i] <= pivot)
                {
                    lowerThanPivot++;
                    Swap(array, lowerThanPivot, i);
                }
            }

            Swap(array, lowerThanPivot + 1, right);
            return lowerThanPivot + 1;
        }

        private static void Swap(int[] array, int i, int lowerThanPivot)
        {
            int temp = array[i];
            array[i] = array[lowerThanPivot];
            array[lowerThanPivot] = temp;
        }



    }
}

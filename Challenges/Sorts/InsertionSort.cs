using System;
using System.Text;

namespace Challenges.Sorts
{
    public class InsertionSort
    {
        public static int[] InsertionSorting(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int current = array[i];

                while (j >= 0 && current < array[j])
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = current;
            }

            return array;
        }

    }
}

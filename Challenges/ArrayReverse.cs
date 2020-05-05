using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class ArrayReverse
    {
        public static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - (1 + i)];
            }

            return reversedArray;
        }
    }
}

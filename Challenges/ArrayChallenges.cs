using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class ArrayChallenges
    {
        // First Array Challenge Method
        public static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - (1 + i)];
            }

            return reversedArray;
        }

        // Second Array Challenge Method
        public static int[] InsertShiftArray(int[] array, int number)
        {
            // Variables to get middle index for insertion
            int middleIndex = 0;
            decimal valueIfArrayLengthIsOdd = array.Length / 2;

            // Returning value of index for even or odd array lengths
            if (array.Length % 2 == 0)
            {
                middleIndex = array.Length / 2;
            }
            else if (array.Length % 2 != 0)
            {
                decimal roundedIndex = Math.Ceiling(valueIfArrayLengthIsOdd);
                middleIndex = (int)roundedIndex + 1;
            }
            
            // New array is created below
            int[] shiftedArray = new int[array.Length + 1];

            for (int i = 0; i < shiftedArray.Length; i++)
            {
                if (i < middleIndex)
                {
                    shiftedArray[i] = array[i];
                }
                if (i == middleIndex)
                {
                    shiftedArray[i] = number;
                }
                if (i > middleIndex)
                {
                    shiftedArray[i] = array[i - 1];
                }
                
            }

            return shiftedArray;
            
        }

    }
}

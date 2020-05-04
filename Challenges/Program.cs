using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");

            int[] firstArray = new int[4] { 1, 2, 3, 4 };
            int[] secondArray = new int[5] { 5, 6, 7, 8, 9 };
            int[] thirdArray = new int[6] { 5, -5, 12, 14, -22, 2 };

            Console.WriteLine("This is the first input array: " + string.Join(",", firstArray));
            ReverseArray(firstArray);

            Console.WriteLine("This is the second input array: " + string.Join(",", secondArray));
            ReverseArray(secondArray);

            Console.WriteLine("This is the second input array: " + string.Join(",", thirdArray));
            ReverseArray(thirdArray);

            Console.ReadLine();
        }

        public static void ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - (1 + i)];
            }

            Console.WriteLine("Output: " + string.Join(",", reversedArray));
        }

    }
}

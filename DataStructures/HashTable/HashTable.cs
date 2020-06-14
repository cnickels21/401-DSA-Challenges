using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashTable
{
    public class HashTable
    {
        private List<LinkedListNode>[] hashTableArray = new List<LinkedListNode>[99];



        public static int GenerateHashCode(string key)
        {
            if (key is null || key == "")
                throw new ArgumentException("Cannot hash key");

            int asciiSum = 0;

            foreach (char letter in key)
            {
                int letterValue = (int)letter;
                asciiSum += letterValue;
            }

            int hashProduct = asciiSum * 599;

            int hashIndex = hashProduct % 99;

            return hashIndex;
        }



    }
}

using System;
using System.Text;
using System.Xml;
using DataStructures.HashTable;

namespace Challenges.HashTableStuff
{
    public class DuplicateSearch
    {
        public static string RepeatingWord(string words)
        {
            if (words == null || words == "")
                return null;

            HashTable myTable = new HashTable(99);
            string lowerWords = words.ToLower();
            string[] allWords = lowerWords.Split(" ");

            foreach (string word in allWords)
            {
                int index = HashTable.GenerateHashCode(word);
                HashTable.Node current = myTable.Buckets[index];

                if (myTable.Buckets[index] != null 
                    && current.Value == word)
                {
                    return word;
                }

                myTable.AddToHashTable(word, word);

                // This below also works but I prefer explicitly verifying the value of the words comparison as above
                //if (myTable.Buckets[index] == null)
                //{
                //    myTable.AddToHashTable(word, word);
                //}
                //else
                //{
                //    return word;
                //}
            }

            return null;
        }
    }
}

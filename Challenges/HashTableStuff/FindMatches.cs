using DataStructures;
using DataStructures.BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges.HashTableStuff
{
    public class FindMatches
    {
        public static List<int> TreeIntersection(BinarySearchTree<int> treeOne, BinarySearchTree<int> treeTwo)
        {
            List<int> result = new List<int>();
            DataStructures.HashTable.HashTable myTable = new DataStructures.HashTable.HashTable(99);

            if (treeOne.Root == null || treeTwo.Root == null)
                return result;

            List<int> treeOneValues = treeOne.PreOrder(treeOne.Root).ToList();
            List<int> treeTwoValues = treeTwo.PreOrder(treeTwo.Root).ToList();

            foreach (var item in treeOneValues)
            {
                string itemKeyValue = item.ToString();
                myTable.AddToHashTable(itemKeyValue, itemKeyValue);
            }

            foreach (var item in treeTwoValues)
            {
                string itemKeyValue = item.ToString();
                int currentIndex = DataStructures.HashTable.HashTable.GenerateHashCode(itemKeyValue);
                DataStructures.HashTable.HashTable.Node current = myTable.Buckets[currentIndex];

                myTable.AddToHashTable(itemKeyValue, itemKeyValue);

                while (current != null)
                {
                    if (current.Value == item.ToString())
                    {
                        if (result.Contains(item))
                        {
                            break;
                        }

                        int match = item;
                        result.Add(match);
                        break;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }

            return result;
        }
    }
}

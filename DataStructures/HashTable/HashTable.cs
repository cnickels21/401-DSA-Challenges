﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashTable
{
    public class HashTable
    {
        public Node[] Buckets { get; set; }
        public int BucketCount { get; set; }
        public HashTable(int buckets)
        {
            Buckets = new Node[buckets];
            BucketCount = buckets;
        }

        public void AddToHashTable(string key, string value)
        {
            int hashTableLocation = GenerateHashCode(key);

            if (Buckets[hashTableLocation].Value == null)
            {
                Node newNode = new Node(key, value);
                Buckets[hashTableLocation] = newNode; 
            }
            else
            {
                Node newNode = new Node(key, value);
                Node current = Buckets[hashTableLocation];
                
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

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

        public class Node
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public Node Next { get; set; }
            public Node(string key, string value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

    }
}

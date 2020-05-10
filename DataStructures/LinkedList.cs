using System;

namespace DataStructures
{
    public class LinkedList
    {
        // Linked list properties defined here
        public Node head;

        // Insert value into linked list
        public void Insert(int value)
        {
            this.head = new Node(value);
        }

        // To string to make testing easier to verify
        public override string ToString()
        {
            if (head == null)
            {
                return "";
            }
            return head.Value.ToString();
        }

        /*-----Node class defined here-----*/
        public class Node
        {
            public Node(int value) // Constructor
            {
                this.Value = value;
                this.Next = null;
            }

            // Node properties defined
            public int Value { get; set; }
            public Node Next { get; set; }
        }
    }
}

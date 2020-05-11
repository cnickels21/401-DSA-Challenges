using System;

namespace DataStructures
{
    public class LinkedList
    {
        // Linked list properties defined here
        public Node head;

        // Insert value into linked list
        public LinkedList Insert(int value, LinkedList singlyList)
        { 
            if (singlyList.head == null)
            {
                this.head = new Node(value);
            }
            while (value < 5)
            {
                Node newNode = new Node(value);
                newNode.Next = singlyList.head;
                singlyList.head = newNode;
                value++;
            }
            return singlyList;
        }

        // To string to make testing easier to verify
        public override string ToString()
        {
            string result = "";

            // Conditions to define return
            if (head == null)
            {
                return result;
            }
            return result += head.Value.ToString();
        }

        public string StringifyFullList()
        {
            // Setup variables accordingly
            Node current = head;
            string result = "";

            // Loop to add each node's value to a string with a comma
            while (current.Next != null)
            {
                result = result + current.Value + ", ";
                current = current.Next;
            }
            return result;
        }

        public static bool CheckIfValueExists(int value, LinkedList verificationList)
        {
            // Setup variables accordingly
            Node current = verificationList.head;
            bool result = false;

            while (current.Next != null)
            {
                current = current.Next;

                if (current.Value == value)
                {
                    result = true;
                    break;
                }
                else if (current.Next == null)
                {
                    result = false;
                    break;
                }
            }

            return result;
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

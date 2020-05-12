using System;

namespace DataStructures
{
    public class LinkedList
    {
        // Linked list properties defined here
        private Node Head;

        // Insert value into linked list
        public void Insert(int value)
        {
            Node newNode = new Node(value);

            try
            {
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    newNode.Next = Head;
                }
                Head = newNode;
            }
            catch (FormatException fex)
            {
                Console.WriteLine("That value is not valid for this type of list. Enter a number between 0 and 4.");
                Console.WriteLine(fex.Message);
                throw;
            }
        }

        // To string to make testing easier to verify
        public override string ToString()
        {
            Node current = Head;
            string result = "";

            // Conditions to define return
            if (Head == null)
            {
                return result;
            }
            while (current != null)
            {
                result += $"{{{current.Value}}} -> ";
                current = current.Next;
            }
            return result + "NULL";
        }

        public bool Includes(int value)
        {
            Node current = Head;

            bool result = false;

            while (current != null)
            {
                if (current.Value == value)
                {
                    result = true;
                    break;
                }
                else
                {
                    current = current.Next;
                }
            }
            return result;
        }

        /*-----Methods for lab 06 linked list insertion-----*/

        public void AppendAtEnd(int value)
        {
            Node current = Head;
            Node appendMe = new Node(value);

            // Traverse list
            while (current.Next != null)
            {
                current = current.Next;
            }
                current.Next = appendMe;
        }

        public void InsertBeforeGivenValue(int value, int newValue)
        {
            Node current = Head;
            Node insertMe = new Node(newValue);

            while (current.Next != null)
            { 
                if (current.Next.Value == value)
                {
                    insertMe.Next = current.Next;
                    current.Next = insertMe;
                    break;
                }
                else if (current.Value == value)
                {
                    insertMe.Next = current;
                    Head = insertMe;
                    break;
                }
                current = current.Next;
            }
        }

        public void InsertAfterGivenValue(int value, int newValue)
        {
            Node current = Head;
            Node insertMe = new Node(newValue);

            while (current.Next != null)
            {
                if (current.Value == value)
                {
                    insertMe.Next = current.Next;
                    current.Next = insertMe;
                    break;
                }
                current = current.Next;
            }
            if (current.Next == null)
            {
                insertMe.Next = current.Next;
                current.Next = insertMe;
            }
        }

        // Method for lab 07 challenges

        public void FindKthValue(int value)
        {
            Node current = Head;

            int listLength = 0;

            while (current != null)
            {
                current = current.Next;
                listLength++;
            }

            if (listLength < value)
                throw new IndexOutOfRangeException("That value is larger than the list length.");

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

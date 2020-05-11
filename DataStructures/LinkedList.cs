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
                    this.Head = newNode;
                }
                //while (value < 5)
                //{
                    
                //    newNode.Next = singlyList.Head;
                //    singlyList.Head = newNode;
                //    value++;
                //}
            }
            catch (FormatException fex) // For some me forsaken reason git won't let me commit this exception
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

        public string StringifyFullList()
        {
            // Setup variables accordingly
            Node current = Head;
            string result = "";

            // Loop to add each node's value to a string with a comma
            while (current.Next != null)
            {
                result = result + current.Value + ", ";
                current = current.Next;
            }
            return result;
        }

        public static bool Includes(int value, LinkedList verificationList)
        {
            // Setup variables accordingly
            Node current = verificationList.Head;
            bool result = false;


            while (current.Next != null)
            {
                if (current.Value == value)
                {
                    result = true;
                    break;
                }
                else if (current.Next == null)
                {
                    result = false;
                }
                else
                {
                    current = current.Next;
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

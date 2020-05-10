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

            while (current.Next != null)
            {
                result = result + current.Value + ", ";
                current = current.Next;
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

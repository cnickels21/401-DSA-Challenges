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
                value++;
                Node newNode = new Node(value);
                newNode.Next = singlyList.head;
                singlyList.head = newNode;
            }
            return singlyList;
        }

        /*
        public LinkedList InsertAtBeginning(int value, LinkedList singlyList)
        {
            if (singlyList.head == null)
            {
                singlyList.Insert(value);
            }
            Node newNode = new Node(value);
            newNode.Next = singlyList.head;
            singlyList.head = newNode;

            return singlyList;
        }
        */

        //public LinkedList InsertMultipleValues(int value, LinkedList listToPopulate)
        //{
        //    listToPopulate.Insert(value);
        //    while (value < 5)
        //    {
        //        listToPopulate.Insert(value + 1);
        //    }
        //    return listToPopulate;
        //}

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

using System;
using System.Text;

namespace DataStructures.Queue
{
    public class Queue<T>
    {
        private Node front;
        private Node rear;

        public T Enqueue(T value)
        {
            Node newRearNode = new Node(value);

            if (rear == null)
            {
                front = rear = newRearNode;
                return rear.Value;
            }

            rear.Next = newRearNode;
            rear = newRearNode;

            return rear.Value;

        }



        public T Peek()
        {
            if (front == null)
                throw new QueueEmptyException();

            return front.Value;
        }

        public class Node
        {
            public Node(T value)
            {
                Value = value;
                Next = null;
            }

            public Node Next { get; set; }
            public T Value { get; set; }
        }
    }
}

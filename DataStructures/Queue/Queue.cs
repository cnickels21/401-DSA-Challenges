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

        public T Dequeue()
        {
            if (front == null)
                throw new QueueEmptyException();

            Node placeHolder = front;
            front = front.Next;
            placeHolder.Next = null;

            if (front == null)
                rear = null;

            return placeHolder.Value;
        }

        public T Peek()
        {
            if (front == null)
                throw new QueueEmptyException();

            return front.Value;
        }

        public bool IsEmpty()
        {
            if (front == null)
            {
                return true;
            }
            return false;
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

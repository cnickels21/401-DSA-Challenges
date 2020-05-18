using System;
using System.Text;

namespace DataStructures.Queue
{
    public class Queue<T>
    {
        private Node front;
        private Node rear;

        public T Peek()
        {
            if (front == null)
                throw new QueueEmptyException();

            return default;
        }

        private class Node
        {
            public Node(T value)
            {
                Value = value;
                Next = null;
            }

            public Node Next { get; }
            public T Value { get; }
        }
    }
}

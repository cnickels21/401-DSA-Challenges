using System;
using System.Text;
using DataStructures.Stack;

namespace Challenges.StacksAndQueues
{
    public class Pseudoqueue<T>
    {
        // Stacks instantiated for pseudoqueue behavior
        Stack<T> firstStack = new Stack<T>();
        Stack<T> secondStack = new Stack<T>();

        // Pseudoqueue field sets defined
        private Node front;
        private Node rear;


        public void Enqueue(T value)
        {
            while (!firstStack.IsEmpty())
            {
                secondStack.Push(firstStack.Pop());
            }

            Node itemToInsert = new Node(firstStack.Push(value));

            if (front == null)
            {
                front = rear = itemToInsert;
            }

            while (!secondStack.IsEmpty())
            {
                firstStack.Push(secondStack.Pop());
            }
        }

        public T Peek()
        {
            if (front == null)
                throw new StackEmptyException();

            return front.Value;
        }

        //if (firstStack.IsEmpty())
        //        throw new QueueEmptyException();

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

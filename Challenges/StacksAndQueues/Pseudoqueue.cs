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

            if (front == null)
            {
                firstStack.Push(value);
                Node seedForEmptyQueue = new Node(firstStack.Peek());
                front = rear = seedForEmptyQueue;
            }
            else
            {
                firstStack.Push(value);
                Node newBottomOfFirstStack = new Node(firstStack.Peek());
                rear.Next = newBottomOfFirstStack;
                rear = newBottomOfFirstStack;
            }

            while (!secondStack.IsEmpty())
            {
                firstStack.Push(secondStack.Pop());
            }
        }

        public T Dequeue()
        {
            if (firstStack.IsEmpty())
                throw new StackEmptyException();

            return default;

        }

        public T Peek()
        {
            if (front == null)
                throw new StackEmptyException();

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

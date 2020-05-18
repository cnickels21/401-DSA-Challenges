using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public class Stack<T>
    {
        private Node top;

        public T Push(T value)
        {
            Node newTop = new Node(value);

            newTop.Next = top;
            top = newTop;

            return top.Value;
        }

        public T Pop()
        {
            if (top == null)
                throw new StackEmptyException();

            Node placeHolder = top;
            top = top.Next;
            placeHolder.Next = null;

            return top.Value;
        }

        public T Peek()
        {

            if (top == null)
                throw new StackEmptyException();

            return top.Value;
        }
        
        public bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }
            return false;
        }

        private class Node
        {
            public Node(T value) { Value = value;  }
            public Node Next { get; set; }
            public T Value { get; }
        }
    }
}

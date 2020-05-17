using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public partial class Stack<T>
    {
        public Node top;

        public T Push(T value)
        {
            Node newTop = new Node(value);

            newTop.Next = top;
            top = newTop;

            return top.Value;
        }

        public T Pop(T value)
        {
            return value;
        }

        public T Peek()
        {
            return top.Value;
        }
        
        public bool IsEmpty()
        {
            return default;
        }

        public class Node
        {
            public Node(T value) { Value = value;  }
            public Node Next { get; set; }
            public T Value { get; }
        }
    }
}

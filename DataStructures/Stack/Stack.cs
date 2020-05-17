using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public partial class Stack<T>
    {
        private Node top;


        private class Node
        {
            public Node Next { get; set; }
            public T Value { get; set; }
        }
    }
}

using System;
using System.Text;

namespace DataStructures.BinaryTree
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }



        // Tree nested Node class
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }
    }
}

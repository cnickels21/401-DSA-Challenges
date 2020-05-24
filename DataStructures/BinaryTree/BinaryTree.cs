using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinaryTree
{
    public class BinaryTree<T>
    {
        public Node Root { get; set; }

        public IEnumerable<T> PreOrder(Node Root)
        {
            if (Root is null)
                yield break;

            yield return Root.Value;

            foreach (T item in PreOrder(Root.Left))
            {
                yield return item;
            }

            foreach (T item in PreOrder(Root.Right))
            {
                yield return item;
            }
        }

        public IEnumerable<T> InOrder(Node Root)
        {
            if (Root is null)
                yield break;

            foreach (T item in InOrder(Root.Left))
            {
                yield return item;
            }

            yield return Root.Value;

            foreach (T item in InOrder(Root.Right))
            {
                yield return item;
            }
        }

        public IEnumerable<T> PostOrder(Node Root)
        {
            if (Root is null)
                yield break;

            foreach (T item in PostOrder(Root.Left))
            {
                yield return item;
            }

            foreach (T item in PostOrder(Root.Right))
            {
                yield return item;
            }

            yield return Root.Value;

        }

        // Tree nested Node class
        public class Node
        {
            public T Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }
    }
}

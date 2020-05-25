using System.Collections.Generic;

namespace DataStructures.BinaryTree
{
    public class BinaryTree<T>
    {
        public Node Root { get; set; }


        public IEnumerable<T> PreOrder(Node root)
        {
            if (root == null)
                yield break;

            yield return root.Value;

            if (root != null)
            {
                if (root.Left != null)
                {
                    foreach (T item in PreOrder(root.Left))
                    {
                        yield return item;
                    }
                }

                if (root.Right != null)
                {
                    foreach (T item in PreOrder(root.Right))
                    {
                        yield return item;
                    }
                }
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

            public IEnumerator<T> GetEnumerator()
            {
                if (Left != null)
                {
                    foreach (T node in Left)
                    {
                        yield return node;
                    }
                }

                yield return Value;

                if (Right != null)
                {
                    foreach (T node in Right)
                    {
                        yield return node;
                    }
                }
            }
        }
    }
}

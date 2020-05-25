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

        public IEnumerable<T> InOrder(Node root)
        {
            if (Root is null)
                yield break;

            if (root != null)
            {
                if (root.Left != null)
                {
                    foreach (T item in InOrder(root.Left))
                    {
                        yield return item;
                    }
                }

                yield return root.Value;

                if (root.Right != null)
                {
                    foreach (T item in InOrder(root.Right))
                    {
                        yield return item;
                    }
                }
            }
        }

        public IEnumerable<T> PostOrder(Node root)
        {
            if (Root is null)
                yield break;

            if (root != null)
            {
                if (root.Left != null)
                {
                    foreach (T item in PostOrder(root.Left))
                    {
                        yield return item;
                    }
                }

                if (root.Right != null)
                {
                    foreach (T item in PostOrder(root.Right))
                    {
                        yield return item;
                    }
                }

                yield return root.Value;
            }
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

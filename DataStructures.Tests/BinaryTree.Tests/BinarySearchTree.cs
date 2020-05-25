using DataStructures.BinaryTree;
using System;

namespace DataStructures.Tests.BinaryTree.Tests
{
    public class BinarySearchTree<T> : BinaryTree<T>
        where T : IComparable<T>
    {

        public void Add(T value)
        {

            Node newNode = new Node(value);
            Node current = Root;
            Node parent = null;

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                while (current != null)
                {
                    parent = current;
                    if (value.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }

                if (value.CompareTo(parent.Value) < 0)
                {
                    parent.Left = newNode;
                }
                else
                {
                    parent.Right = newNode;
                }
            }
        }

        // Contains boolean method
        public bool Contains(Node root, T value)
        {
            while (root != null)
            {
                if (root.Value.Equals(value))
                {
                    return true;
                }
                else if (root.Value.CompareTo(value) > 0)
                {
                    return Contains(root.Left, value);
                }
                else
                {
                    return Contains(root.Right, value);
                }
            }

            return false;
        }

    }
}

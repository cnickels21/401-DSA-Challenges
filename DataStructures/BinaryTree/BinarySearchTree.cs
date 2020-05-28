using System;
using System.Collections.Generic;

namespace DataStructures.BinaryTree
{
    public class BinarySearchTree<T> : ComparableBinaryTree<T>
        where T : IComparable<T>
    {

        public override T MaxValue()
        {
            if (this.Root == null)
                return default;

            Queue<Node> filterQueue = new Queue<Node>();
            filterQueue.Enqueue(this.Root);
            filterQueue.Enqueue(this.Root.Left);

            T ultimateReturn = default;

            while (filterQueue.Count > 1)
            {
                Node front = filterQueue.Dequeue();
                Node valueToCompare = filterQueue.Peek();

                if (front.Left != null)
                {
                    filterQueue.Enqueue(front.Left);
                }
                if (front.Right != null)
                {
                    filterQueue.Enqueue(front.Right);
                }

                if (front.Value.CompareTo(valueToCompare.Value) == 1)
                {
                    filterQueue.Enqueue(front);
                    filterQueue.Dequeue();
                }
                else if (front.Value.CompareTo(valueToCompare.Value) == 1)
                {
                    continue;
                }
                else if (front.Value.CompareTo(valueToCompare.Value) == 0)
                {
                    continue;
                }

                ultimateReturn = front.Value;
            }

            return ultimateReturn;
        }

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

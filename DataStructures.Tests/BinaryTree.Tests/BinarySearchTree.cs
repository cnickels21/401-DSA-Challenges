using DataStructures.BinaryTree;
using Newtonsoft.Json.Linq;
using System;
using System.Text;
using System.Collections.Generic;

namespace DataStructures.Tests.BinaryTree.Tests
{
    public class BinarySearchTree<T> : BinaryTree<T>
        where T : IComparable<T>
    {

        public void Add(T value)
        {

            Node newNode = new Node(value);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node current = Root;
                Node parent = current;

                while (true)
                {

                    if (value.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;

                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;

                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
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

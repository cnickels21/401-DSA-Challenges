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

                while (true)
                {

                    if (value.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;

                        if (current == null)
                        {
                            current = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;

                        if (current == null)
                        {
                            current = newNode;
                            break;
                        }
                    }
                }
            }

        }

    }
}

// using DataStructures.Queue;

using System;
using System.Collections.Generic;

namespace DataStructures.BinaryTree
{
    public class ComparableBinaryTree<T> : BinaryTree<T>
        where T : IComparable<T>
    {
        public T MaxValue()
        {
            if (this.Root == null)
                return default;

            Queue<Node> filterQueue = new Queue<Node>();
            filterQueue.Enqueue(this.Root);

            while (filterQueue.Count > 1)
            {
                Node front = filterQueue.Dequeue();

                // if (front.Value > front.Left.Value || )
            }

            return default;
        }
    }
}

// using DataStructures.Queue;

using System;

namespace DataStructures.BinaryTree
{
    public class ComparableBinaryTree<T> : BinaryTree<T>
        where T : IComparable<T>
    {
        public virtual T MaxValue()
        {
            return default;
        }
    }
}

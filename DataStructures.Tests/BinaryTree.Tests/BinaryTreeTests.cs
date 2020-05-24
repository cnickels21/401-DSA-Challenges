using DataStructures.BinaryTree;
using System;
using System.Text;
using Xunit;

namespace DataStructures.Tests.BinaryTree.Tests
{
    public class BinaryTreeTests
    {
        /// <summary>
        /// 1. Can successfully instantiate an empty tree -- DONE
        /// 2. Can successfully instantiate a tree with a single root node
        /// 3. Can successfully add a left child and right child to a single root node
        /// 4. Can successfully return a collection from a preorder traversal
        /// 5. Can successfully return a collection from an inorder traversal
        /// 6. Can successfully return a collection from a postorder traversal
        /// </summary>
        [Fact]
        public void Can_create_empty_tree()
        {
            // Act
            BinaryTree<int> testTree = new BinaryTree<int>();

            // Assert
            Assert.Throws<NullReferenceException>(() =>
                    testTree.Root.Value
                );
        }



    }
}

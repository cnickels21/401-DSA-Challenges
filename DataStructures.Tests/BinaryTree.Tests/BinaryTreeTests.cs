﻿using DataStructures.BinaryTree;
using System;
using System.Text;
using Xunit;

namespace DataStructures.Tests.BinaryTree.Tests
{
    public class BinaryTreeTests
    {
        /// <summary>
        /// 1. Can successfully instantiate an empty tree -- DONE
        /// 2. Can successfully instantiate a tree with a single root node -- DONE
        /// 3. Can successfully add a left child and right child to a single root node -- DONE
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

        [Fact]
        public void Can_add_value_to_root_node()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();

            // Act
            testTree.Add(1);

            // Assert
            Assert.Equal(1, testTree.Root.Value);
            
        }

        [Fact]
        public void Can_add_value_to_left_node()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(2);

            // Act
            testTree.Add(1);

            // Assert
            Assert.Equal(1, testTree.Root.Left.Value);

        }

        [Fact]
        public void Can_add_value_to_right_node()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(2);

            // Act
            testTree.Add(3);

            // Assert
            Assert.Equal(3, testTree.Root.Right.Value);

        }

        [Fact]
        public void Contains_returns_true_and_false_respectively()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(2);
            testTree.Add(3);
            testTree.Add(1);

            // Act
            bool rootValue = testTree.Contains(testTree.Root, 2);
            bool leftValue = testTree.Contains(testTree.Root, 1);
            bool rightValue = testTree.Contains(testTree.Root, 3);
            bool existentialCrisis = testTree.Contains(testTree.Root, 4);

            // Assert
            Assert.True(rootValue);
            Assert.True(leftValue);
            Assert.True(rightValue);
            Assert.False(existentialCrisis);

        }

    }
}

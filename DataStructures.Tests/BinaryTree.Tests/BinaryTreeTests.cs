﻿using DataStructures.BinaryTree;
using System;
using System.Collections;
using Xunit;

namespace DataStructures.Tests.BinaryTree.Tests
{
    public class BinaryTreeTests
    {
        /// <summary>
        /// 1. Can successfully instantiate an empty tree -- DONE
        /// 2. Can successfully instantiate a tree with a single root node -- DONE
        /// 3. Can successfully add a left child and right child to a single root node -- DONE
        /// 4. Can successfully return a collection from a preorder traversal -- DONE
        /// 5. Can successfully return a collection from an inorder traversal -- DONE
        /// 6. Can successfully return a collection from a postorder traversal -- DONE
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

        [Fact]
        public void Preorder_traversal_functional()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(2);
            testTree.Add(3);
            testTree.Add(1);

            int[] expected = new int[]
            {
                2,
                1,
                3,
            };

            // Act
            IEnumerable result = testTree.PreOrder(testTree.Root);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Preorder_traversal_for_larger_tree()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(5);
            testTree.Add(3);
            testTree.Add(10);
            testTree.Add(1);
            testTree.Add(4);
            testTree.Add(7);
            testTree.Add(11);


            int[] expected = new int[]
            {
                5,
                3,
                1,
                4,
                10,
                7,
                11,
            };

            // Act
            IEnumerable result = testTree.PreOrder(testTree.Root);

            // Assert
            Assert.True(testTree.Contains(testTree.Root, 7));
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Inorder_traversal_for_larger_tree()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(5);
            testTree.Add(3);
            testTree.Add(10);
            testTree.Add(1);
            testTree.Add(4);
            testTree.Add(7);
            testTree.Add(11);


            int[] expected = new int[]
            {
                1,
                3,
                4,
                5,
                7,
                10,
                11,
            };

            // Act
            IEnumerable result = testTree.InOrder(testTree.Root);

            // Assert
            Assert.True(testTree.Contains(testTree.Root, 7));
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Postorder_traversal_for_larger_tree()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Add(5);
            testTree.Add(3);
            testTree.Add(10);
            testTree.Add(1);
            testTree.Add(4);
            testTree.Add(7);
            testTree.Add(11);


            int[] expected = new int[]
            {
                1,
                4,
                3,
                7,
                11,
                10,
                5,
            };

            // Act
            IEnumerable result = testTree.PostOrder(testTree.Root);

            // Assert
            Assert.True(testTree.Contains(testTree.Root, 7));
            Assert.Equal(expected, result);
        }

        [Fact(Skip = "Edge case yet to be handled correctly")]
        public void Contains_null_value()
        {
            BinarySearchTree<string> testTree = new BinarySearchTree<string>();

            testTree.Add(null);
            testTree.Add("false");
            testTree.Add("true");
            testTree.Add("true");

            Assert.True(testTree.Contains(testTree.Root, null));
            Assert.True(testTree.Contains(testTree.Root, "true"));
            Assert.True(testTree.Contains(testTree.Root, "false"));
        }

        [Fact]
        public void Can_return_empty_from_empty_tree()
        {
            // Arrange
            BinaryTree<int> testTree = new BinaryTree<int>();
            int[] expected = new int[0];

            // Assert
            Assert.Equal(expected, testTree.BreadthFirst());
        }

        [Fact]
        public void Can_instantiate_queue_with_tree_root()
        {
            // Arrange
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Root = new BinaryTree<int>.Node(1);

            int[] expected = new int[]
            {
                1,
            };

            // Assert
            Assert.Equal(expected, testTree.BreadthFirst());
        }

        [Fact]
        public void Can_perform_breadth_first_on_three_values()
        {
            // Arrange
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Root = new BinaryTree<int>.Node(2);
            testTree.Root.Left = new BinaryTree<int>.Node(1);
            testTree.Root.Right = new BinaryTree<int>.Node(3);

            int[] expected = new int[]
            {
                2,
                1,
                3,
            };

            // Assert
            Assert.Equal(expected, testTree.BreadthFirst());
        }

        /// <summary>
        /// Unit Tests for Max Value:
        /// 1. Empty tree returns empty -- DONE
        /// 2. Find largest value in 3 nodes -- DONE
        /// 3. Find largest value in more nodes -- DONE
        /// 4. Values are equal -- DONE
        /// </summary>
        /// 
        [Fact]
        public void Can_return_empty_if_empty()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();

            int expected = 0;

            // Act & Assert
            Assert.Equal(expected, testTree.MaxValue());
        }

        [Fact]
        public void Can_return_largest_value_of_three()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Root = new BinaryTree<int>.Node(2);
            testTree.Root.Left = new BinaryTree<int>.Node(1);
            testTree.Root.Right = new BinaryTree<int>.Node(3);

            int expected = 3;

            // Act & Assert
            Assert.Equal(expected, testTree.MaxValue());
        }

        [Fact]
        public void Can_return_largest_value_of_five_values()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Root = new BinaryTree<int>.Node(2);
            testTree.Root.Left = new BinaryTree<int>.Node(1);
            testTree.Root.Right = new BinaryTree<int>.Node(3);
            testTree.Root.Left.Right = new BinaryTree<int>.Node(2);
            testTree.Root.Right.Left = new BinaryTree<int>.Node(7);

            int expected = 7;

            // Act & Assert
            Assert.Equal(expected, testTree.MaxValue());
        }

        [Fact]
        public void Can_return_value_if_all_nodes_are_equal()
        {
            // Arrange
            BinarySearchTree<int> testTree = new BinarySearchTree<int>();
            testTree.Root = new BinaryTree<int>.Node(2);
            testTree.Root.Left = new BinaryTree<int>.Node(2);
            testTree.Root.Right = new BinaryTree<int>.Node(2);

            int expected = 2;

            // Act & Assert
            Assert.Equal(expected, testTree.MaxValue());
        }

    }
}

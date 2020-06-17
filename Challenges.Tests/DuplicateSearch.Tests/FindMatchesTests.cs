using DataStructures.BinaryTree;
using System;
using System.Text;
using Xunit;
using Challenges.HashTableStuff;
using DataStructures;
using System.Collections.Generic;

namespace Challenges.Tests.DuplicateSearch.Tests
{
    public class FindMatchesTests
    {
        [Fact]
        public void Empty_tree_returns_empty_list()
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int>();
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int>();

            // Act
            List<int> result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.True(result.Count == 0);
        }

        [Fact]
        public void One_empty_tree_returns_empty_list()
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int>();
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int>();

            treeOne.Add(1);

            // Act
            List<int> result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.True(result.Count == 0);
        }

        [Fact]
        public void Second_empty_tree_returns_empty_list()
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int>();
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int>();

            treeTwo.Add(1);

            // Act
            List<int> result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.True(result.Count == 0);
        }

        [Fact]
        public void Can_find_a_single_match()
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int>();
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int>();
            List<int> expected = new List<int>();

            expected.Add(8);

            treeOne.Add(2);
            treeOne.Add(4);
            treeOne.Add(6);
            treeOne.Add(8);

            treeTwo.Add(1);
            treeTwo.Add(3);
            treeTwo.Add(5);
            treeTwo.Add(8);

            // Act
            List<int> result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_find_multiple_match()
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int>();
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int>();
            List<int> expected = new List<int>();

            expected.Add(4);
            expected.Add(8);

            treeOne.Add(4);
            treeOne.Add(2);
            treeOne.Add(6);
            treeOne.Add(8);

            treeTwo.Add(5);
            treeTwo.Add(4);
            treeTwo.Add(1);
            treeTwo.Add(8);

            // Act
            List<int> result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Edge_case_of_twelve_and_twentyOne()
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int>();
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int>();
            List<int> expected = new List<int>();

            expected.Add(12);
            expected.Add(21);

            treeOne.Add(4);
            treeOne.Add(2);
            treeOne.Add(12);
            treeOne.Add(21);

            treeTwo.Add(5);
            treeTwo.Add(12);
            treeTwo.Add(21);
            treeTwo.Add(8);

            // Act
            List<int> result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Edge_case_of_matching_matches()
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int>();
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int>();
            List<int> expected = new List<int>();

            expected.Add(12);
            // expected.Add(12);

            treeOne.Add(4);
            treeOne.Add(2);
            treeOne.Add(12);
            treeOne.Add(21);

            treeTwo.Add(5);
            treeTwo.Add(12);
            treeTwo.Add(12);
            treeTwo.Add(8);

            // Act
            List<int> result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

using DataStructures.BinaryTree;
using System;
using System.Text;
using Xunit;
using Challenges.HashTableStuff;
using DataStructures;

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
            LinkedList expected = new LinkedList();

            // Act
            LinkedList result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.True(result.Head == null);
        }

        [Fact]
        public void One_empty_tree_returns_empty_list()
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int>();
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int>();
            LinkedList expected = new LinkedList();

            treeOne.Add(1);

            // Act
            LinkedList result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.True(result.Head == null);
        }

        [Fact]
        public void Second_empty_tree_returns_empty_list()
        {
            // Arrange
            BinarySearchTree<int> treeOne = new BinarySearchTree<int>();
            BinarySearchTree<int> treeTwo = new BinarySearchTree<int>();
            LinkedList expected = new LinkedList();

            treeTwo.Add(1);

            // Act
            LinkedList result = FindMatches.TreeIntersection(treeOne, treeTwo);

            // Assert
            Assert.True(result.Head == null);
        }
    }
}

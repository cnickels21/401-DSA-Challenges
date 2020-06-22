using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.HashTable;
using Challenges.HashTableStuff;

namespace Challenges.Tests.DuplicateSearch.Tests
{
    public class LeftJoinTablesTests
    {
        [Fact]
        public void First_tree_is_empty()
        {
            // Arrange
            HashTable testTableOne = new HashTable(99);
            HashTable testTableTwo = new HashTable(99);

            string[][] expected = new string[99][];

            // Act
            string[][] result = LeftJoinTables.LeftJoin(testTableOne, testTableTwo);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void First_table_has_values()
        {
            // Arrange
            HashTable testTableOne = new HashTable(99);
            HashTable testTableTwo = new HashTable(99);

            testTableOne.AddToHashTable("time", "day");

            string[][] expected = new string[99][];

            // Act
            string[][] result = LeftJoinTables.LeftJoin(testTableOne, testTableTwo);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

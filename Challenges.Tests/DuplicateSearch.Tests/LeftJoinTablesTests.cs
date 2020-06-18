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

            HashTable expected = new HashTable(99);

            // Act
            HashTable result = LeftJoinTables.LeftJoin(testTableOne, testTableTwo);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

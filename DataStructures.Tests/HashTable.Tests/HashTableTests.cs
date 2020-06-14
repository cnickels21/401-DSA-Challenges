
using DataStructures.HashTable;
using System;
using System.Text;
using Xunit;

namespace DataStructures.Tests.HashTable.Tests
{
    public class HashTableTests
    {
        [Fact]
        public void Can_hash_string_into_key()
        {
            // Arrange
            string key = "Cat";

            // Act
            int result = DataStructures.HashTable.HashTable.GenerateHashCode(key);

            // Assert
            Assert.Equal(14, result);
        }
    }
}

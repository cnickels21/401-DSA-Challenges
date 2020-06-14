
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

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Arguement_exception_for_invalid_keys(string key)
        {
            // Arrange in parameters

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                var result = DataStructures.HashTable.HashTable.GenerateHashCode(key);
            });
        }

        [Fact]
        public void Can_add_a_key_value_pair_to_table()
        {
            // Arrange
            string testKey = "Cat";
            string testValue = "Milo";

            // Act
            DataStructures.HashTable.HashTable.AddToHashTable(testKey, testValue);

        }



    }
}

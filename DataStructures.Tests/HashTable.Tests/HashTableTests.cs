
using DataStructures.HashTable;
using System;
using System.Text;
using Xunit;

namespace DataStructures.Tests.HashTable.Tests
{
    public class HashTableTests
    {
        /// <summary>
        /// 1. Adding a key/value to your hashtable results in the value being in the data structure -- DONE
        /// 2. Retrieving based on a key returns the value stored -- DONE
        /// 3. Successfully returns null for a key that does not exist in the hashtable -- DONE
        /// 4. Successfully handle a collision within the hashtable -- DONE
        /// 5. Successfully retrieve a value from a bucket within the hashtable that has a collision -- DONE
        /// 6. Successfully hash a key to an in-range value -- DONE
        /// </summary>
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

        /// <summary>
        /// This test actually proves that my add and contains are working correctly
        /// </summary>
        [Fact]
        public void Can_add_a_key_value_pair_to_table()
        {
            // Arrange
            DataStructures.HashTable.HashTable testTable = new DataStructures.HashTable.HashTable(99);
            string testKey = "Cat";
            string testValue = "Milo";

            // Act
            testTable.AddToHashTable(testKey, testValue);

            // Assert
            Assert.True(testTable.TableContains("Cat"));
            Assert.False(testTable.TableContains("Dog"));
        }

        [Fact]
        public void Can_get_value_from_table()
        {
            // Arrange
            DataStructures.HashTable.HashTable testTable = new DataStructures.HashTable.HashTable(99);
            string testKey = "Cat";
            string testValue = "Milo";

            testTable.AddToHashTable(testKey, testValue);

            // Act
            string result = testTable.GetFromTable(testKey);

            // Assert
            Assert.Equal("Milo", result);
        }

        [Fact]
        public void Can_return_null_if_key_is_invalid()
        {
            // Arrange
            DataStructures.HashTable.HashTable testTable = new DataStructures.HashTable.HashTable(99);
            string testKey = "Cat";
            string testValue = "Milo";

            testTable.AddToHashTable(testKey, testValue);

            // Act
            string result = testTable.GetFromTable("Dog");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Can_handle_a_collision()
        {
            // Arrange
            DataStructures.HashTable.HashTable testTable = new DataStructures.HashTable.HashTable(99);
            string testKey = "Cat";
            string testValue = "Milo";

            string secondKey = "Act";
            string secondValue = "Garfield";

            testTable.AddToHashTable(testKey, testValue);
            testTable.AddToHashTable(secondKey, secondValue);

            // Act
            string result = testTable.GetFromTable(testKey);
            string secondResult = testTable.GetFromTable(secondKey);

            // Assert
            Assert.Equal("Milo", result);
            Assert.Equal("Garfield", secondResult);
        }



    }
}

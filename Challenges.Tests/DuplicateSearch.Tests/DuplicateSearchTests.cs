using System;
using System.Text;
using Xunit;
using Challenges.HashTableStuff;

namespace Challenges.Tests.DuplicateSearch.Tests
{
    public class DuplicateSearchTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Can_return_null_on_empty_string_or_null(string actual)
        {
            // Arrange in parameter

            // Act
            var result = HashTableStuff.DuplicateSearch.RepeatingWord(actual);

            // Assert
            Assert.Null(result);
        }
    }
}

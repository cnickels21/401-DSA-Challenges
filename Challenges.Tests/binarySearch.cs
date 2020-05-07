using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class binarySearch
    {
        [Fact]
        public void Finds_index_location()
        {
            int[] input = new[] { 4, 8, 15, 16, 23, 42 };
            int result = ArrayChallenges.BinarySearch(input, 15);
            Assert.Equal(2, result);
        }
        [Fact]
        public void Number_does_not_exist()
        {
            int[] input = new[] { 11, 22, 33, 44, 55, 66, 77 };
            int result = ArrayChallenges.BinarySearch(input, 90);
            Assert.Equal(-1, result);
        }
    }
}

using System;
using System.Text;
using Xunit;
using Challenges.Sorts;
using Xunit.Sdk;

namespace Challenges.Tests.Sorts
{
    public class MergeSortTests
    {
        [Fact]
        public void Can_sort_an_empty_array()
        {
            // Arrange
            int[] testArray = new int[0];
            int[] expected = new int[0];

            // Act
            int[] result = MergeSort.MergeSorter(testArray);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 8, 4, 23, 42, 16, 15 }, new int[] { 4, 8, 15, 16, 23, 42 })]
        public void Theory_to_merge_sort_variety_of_arrays(int[] actual, int[] expected)
        {
            // Arrange in parameters

            // Act
            int[] result = MergeSort.MergeSorter(actual);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}

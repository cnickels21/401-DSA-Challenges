using System;
using System.Text;
using Xunit;
using Challenges.Sorts;

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
    }
}

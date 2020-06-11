using System;
using System.Text;
using Challenges.Sorts;
using Xunit;

namespace Challenges.Tests.Sorts
{
    public class SuperQuickSortTests
    {
        [Fact]
        public void Can_return_empty_array()
        {
            // Arrangessssssssss
            int[] testArray = new int[0];
            int[] expected = new int[0];

            // Act
            int[] result = SuperQuickSort.QuickSort(testArray);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 8, 4, 23, 42, 16, 15 }, new int[] { 4, 8, 15, 16, 23, 42 })]
        public void Theory_for_multiple_edge_cases(int[] actual, int[] expected)
        {
            // Arrange in parameters

            // Act
            int[] result = SuperQuickSort.QuickSort(actual);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

using System;
using System.Text;
using Challenges.Sorts;
using Xunit;

namespace Challenges.Tests.Sorts
{
    public class SuperQuickSortTests
    {
        [Theory]
        [InlineData(new int[0], new int[0])]
        [InlineData(new int[] { 8, 4, 23, 42, 16, 15 }, new int[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new int[] { 3, 2 }, new int[] { 2, 3 })]
        [InlineData(new int[] { 3, 2, 1}, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 3, 2, 4, 1 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 20, 18, 12, 8, 5, -2 }, new int[] { -2, 5, 8, 12, 18, 20 })]
        [InlineData(new int[] { 5, 12, 7, 5, 5, 7 }, new int[] { 5, 5, 5, 7, 7, 12 })]
        [InlineData(new int[] { 2, 3, 5, 7, 13, 11 }, new int[] { 2, 3, 5, 7, 11, 13 })]
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

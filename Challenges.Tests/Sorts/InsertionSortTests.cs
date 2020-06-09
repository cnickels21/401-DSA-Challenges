using System;
using System.Text;
using Xunit;
using Challenges.Sorts;

namespace Challenges.Tests.Sorts
{
    public class InsertionSortTests
    {
        [Fact]
        public void Empty_Array_Returns_Empty_Array()
        {
            // Arrange
            int[] testArray = new int[0];
            int[] expected = new int[0];

            // Act
            int[] result = InsertionSort.InsertionSorting(testArray);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 3, 1, 2 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 8, 4, 23, 42, 16, 15}, new[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new[] { 20, 18, 12, 8, 5, -2 }, new[] { -2, 5, 8, 12, 18, 20 })]
        [InlineData(new[] { 5, 12, 7, 5, 5, 7 }, new[] { 5, 5, 5, 7, 7, 12 })]
        [InlineData(new[] { 2, 3, 5, 7, 13, 11 }, new[] { 2, 3, 5, 7, 11, 13 })]
        public void Multiple_test_data_passed_through_sort(int[] testArray, int[] expected)
        {
            // Arrange in parameters

            // Act
            int[] result = InsertionSort.InsertionSorting(testArray);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}

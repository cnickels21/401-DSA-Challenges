﻿using System;
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

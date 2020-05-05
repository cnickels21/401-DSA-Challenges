using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class ArrayShiftTests
    {
        [Fact]
        public void Can_insert_number_into_middle_of_array()
        {
            // Arrange
            int[] inputArray = { 1, 2, 3, 4 };
            int inputNumber = 5;
            int[] expected = { 1, 2, 5, 3, 4 };

            // Act
            int[] result = ArrayChallenges.InsertShiftArray(inputArray, inputNumber);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

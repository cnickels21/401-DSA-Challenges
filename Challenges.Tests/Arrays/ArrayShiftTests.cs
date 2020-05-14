using Xunit;

namespace Challenges.Tests.Arrays
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

        [Fact]
        public void Can_insert_number_into_middle_of_odd_length_array()
        {
            int[] inputArray = { 5, 6, 7, 8, 9 };
            int inputNumber = 10;
            int[] expected = { 5, 6, 7, 10, 8, 9 };

            int[] result = ArrayChallenges.InsertShiftArray(inputArray, inputNumber);

            Assert.Equal(expected, result);
        }
    }
}

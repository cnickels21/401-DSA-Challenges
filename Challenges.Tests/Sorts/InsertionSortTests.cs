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

            // Act
            int[] result = InsertionSort.InsertionSorting(testArray);
        }

    }
}

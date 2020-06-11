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
    }
}

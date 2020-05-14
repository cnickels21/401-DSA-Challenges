using DataStructures;
using System;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
    public class LinkedListMergeTests
    {

        [Fact]
        public void Can_return_a_list()
        {
            // Arrange
            LinkedList listOne = new LinkedList();
            LinkedList listTwo = new LinkedList();

            listOne.Insert(1);
            listOne.AppendAtEnd(3);

            listTwo.Insert(5);

            // Act
            LinkedList result = LinkedListChallenges.MergeLists(listOne, listTwo);

            // Assert
            Assert.Equal(listOne, result);
        }

        [Fact]
        public void Can_return_short_merged_list()
        {
            // Arrange
            LinkedList listOne = new LinkedList();
            LinkedList listTwo = new LinkedList();

            listOne.Insert(1);
            listOne.AppendAtEnd(3);

            listTwo.Insert(5);

            // Act
            LinkedList result = LinkedListChallenges.MergeLists(listOne, listTwo);

            // Assert
            Assert.Equal("{1} -> {2} -> {3} -> NULL", result.ToString());
        }
    }
}

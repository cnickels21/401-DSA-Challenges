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
            Assert.Equal("{1} -> {5} -> {3} -> NULL", result.ToString());
        }

        [Fact]
        public void Can_return_short_merged_list()
        {
            // Arrange
            LinkedList listOne = new LinkedList();
            LinkedList listTwo = new LinkedList();

            listOne.Insert(1);
            listOne.AppendAtEnd(3);

            listTwo.Insert(2);

            // Act
            LinkedList result = LinkedListChallenges.MergeLists(listOne, listTwo);

            // Assert
            Assert.Equal("{1} -> {2} -> {3} -> NULL", result.ToString());
        }

        [Fact]
        public void Two_lists_are_same_length()
        {
            // Arrange
            LinkedList listOne = new LinkedList();
            LinkedList listTwo = new LinkedList();

            listOne.Insert(1);
            listOne.AppendAtEnd(3);

            listTwo.Insert(2);
            listOne.AppendAtEnd(4);


            // Act
            LinkedList result = LinkedListChallenges.MergeLists(listOne, listTwo);

            // Assert
            Assert.Equal("{1} -> {2} -> {3} -> {4} -> NULL", result.ToString());
        }

        [Fact]
        public void First_list_is_empty()
        {
            // Arrange
            LinkedList listOne = new LinkedList();
            LinkedList listTwo = new LinkedList();

            listTwo.Insert(1);
            listTwo.AppendAtEnd(3);



            // Assert
            Assert.Throws<NullReferenceException>(() =>
            {
                // Act
                LinkedListChallenges.MergeLists(listOne, listTwo);
            });
        }

        [Fact]
        public void Second_list_is_empty()
        {
            // Arrange
            LinkedList listOne = new LinkedList();
            LinkedList listTwo = new LinkedList();

            listOne.Insert(1);
            listOne.AppendAtEnd(3);



            // Assert
            Assert.Throws<NullReferenceException>(() =>
            {
                // Act
                LinkedListChallenges.MergeLists(listOne, listTwo);
            });
        }
    }
}

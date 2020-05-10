using System;
using Xunit;

namespace DataStructures.Tests
{
    public class LinkedListTests
    {

        /*
        Can successfully instantiate an empty linked list -- DONE
        Can properly insert into the linked list
        The head property will properly point to the first node in the linked list
        Can properly insert multiple nodes into the linked list
        Will return true when finding a value within the linked list that exists
        Will return false when searching for a value in the linked list that does not exist
        Can properly return a collection of all the values that exist in the linked list
        */

        [Fact]
        public void Can_create_empty_linked_list()
        {
            // Act
            LinkedList myNewList = new LinkedList();

            // Assert
            Assert.Equal("", myNewList.ToString());
        }

        [Fact]
        public void Can_insert_into_list()
        {
            // Arrange
            LinkedList listToAddTo = new LinkedList();

            // Act
            listToAddTo.Insert(1);

            // Assert
            Assert.Equal("1", listToAddTo.ToString());
        }
    }
}

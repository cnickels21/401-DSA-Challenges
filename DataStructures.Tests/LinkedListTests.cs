using System;
using Xunit;

namespace DataStructures.Tests
{
    public class LinkedListTests
    {

        /*
        1. Can successfully instantiate an empty linked list -- DONE
        2. Can properly insert into the linked list -- DONE
        3. The Head property will properly point to the first node in the linked list --  DONE
        4. Can properly insert multiple nodes into the linked list -- DONE
        5. Will return true when finding a value within the linked list that exists -- DONE
        6. Will return false when searching for a value in the linked list that does not exist -- DONE
        7. Can properly return a collection of all the values that exist in the linked list -- DONE
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
            Assert.Equal("{1} -> NULL", listToAddTo.ToString());
        }

        [Fact]
        public void Can_point_to_head_node()
        {
            // Arrange
            LinkedList listToAccessHead = new LinkedList();
            listToAccessHead.Insert(1);

            // Act
            string result = listToAccessHead.ToString();

            // Assert
            Assert.Equal("{1} -> NULL", result);
        }

        // This test technically proves that I can insert multiple values and return all of the values from a list stringified -- BEFORE REFACTORING that is...it used to be setup as taking in and returning a list accordingly but has been refactored to be more conventional for the sake of our use here.
        [Fact]
        public void Can_insert_multiple_values()
        {
            // Arrange
            LinkedList listToPopulate = new LinkedList();

            // Act
            listToPopulate.Insert(3);
            listToPopulate.Insert(2);
            listToPopulate.Insert(1);

            // Assert
            Assert.Equal("{1} -> {2} -> {3} -> NULL", listToPopulate.ToString());
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(0, false)]
        public void Can_check_for_value_in_list(int value, bool expected)
        {
            // Arrange
            LinkedList verificationList = new LinkedList();
            verificationList.Insert(4);
            verificationList.Insert(3);
            verificationList.Insert(2);
            verificationList.Insert(1);

            // Act
            // bool result = verificationList.Includes(value);
            bool result = verificationList.Includes(value);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Class 06 - Linked List Appending/Insertion
        /// </summary>
        /*
        1. Can successfully add a node to the end of the linked list -- DONE
        2. Can successfully add multiple nodes to the end of a linked list -- DONE
        3. Can successfully insert a node before a node located in the middle of a linked list -- DONE
        4. Can successfully insert a node before the first node of a linked list -- DONE
        5. Can successfully insert after a node in the middle of the linked list -- DONE
        6. Can successfully insert a node after the last node of the linked list -- DONE
        */

        [Fact]
        public void Can_insert_at_end_of_list()
        {
            // Arrange
            LinkedList listForAppend = new LinkedList();
            listForAppend.Insert(2);
            listForAppend.Insert(1);

            // Act
            listForAppend.AppendAtEnd(3);

            // Assert
            Assert.Equal("{1} -> {2} -> {3} -> NULL", listForAppend.ToString());
        }

        [Fact]
        public void Can_insert_multiple_at_end_of_list()
        {
            // Arrange
            LinkedList listForAppend = new LinkedList();
            listForAppend.Insert(2);
            listForAppend.Insert(1);

            // Act
            listForAppend.AppendAtEnd(3);
            listForAppend.AppendAtEnd(4);

            // Action below was used to prove test fails
            // listForAppend.AppendAtEnd(5);

            // Assert
            Assert.Equal("{1} -> {2} -> {3} -> {4} -> NULL", listForAppend.ToString());
        }

        [Fact]
        public void Can_insert_before_node_of_specified_value()
        {
            // Arrange
            LinkedList insertBeforeValue = new LinkedList();
            insertBeforeValue.Insert(3);
            insertBeforeValue.Insert(1);

            // Act
            insertBeforeValue.InsertBeforeGivenValue(3, 2);

            // Assert
            Assert.Equal("{1} -> {2} -> {3} -> NULL", insertBeforeValue.ToString());
        }

        [Fact]
        public void Can_insert_before_first_node_of_specified_value()
        {
            // Arrange
            LinkedList insertBeforeValue = new LinkedList();
            insertBeforeValue.Insert(3);
            insertBeforeValue.Insert(1);

            // Act
            insertBeforeValue.InsertBeforeGivenValue(1, 2);

            // Assert
            Assert.Equal("{2} -> {1} -> {3} -> NULL", insertBeforeValue.ToString());
        }

        [Fact]
        public void Can_insert_after_node_of_specified_value()
        {
            // Arrange
            LinkedList insertBeforeValue = new LinkedList();
            insertBeforeValue.Insert(4);
            insertBeforeValue.Insert(2);
            insertBeforeValue.Insert(1);

            // Act
            insertBeforeValue.InsertAfterGivenValue(2, 3);

            // Assert
            Assert.Equal("{1} -> {2} -> {3} -> {4} -> NULL", insertBeforeValue.ToString());
        }

        [Fact]
        public void Can_insert_after_last_node_of_specified_value()
        {
            // Arrange
            LinkedList insertBeforeValue = new LinkedList();
            insertBeforeValue.Insert(3);
            insertBeforeValue.Insert(2);
            insertBeforeValue.Insert(1);

            // Act
            insertBeforeValue.InsertAfterGivenValue(3, 4);

            // Assert
            Assert.Equal("{1} -> {2} -> {3} -> {4} -> NULL", insertBeforeValue.ToString());
        }

        /// <summary>
        /// Lab 07 kth from end tests
        /// 1. Where k is greater than the length of the linked list
        /// 2. Where k and the length of the list are the same
        /// 3. Where k is not a positive integer
        /// 4. Where the linked list is of a size 1
        /// 5. “Happy Path” where k is not at the end, but somewhere in the middle of the linked list
        /// </summary>

        [Fact]
        public void Value_given_is_larger_than_length_of_list()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            // Assert
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                // Act
                list.FindKthValue(2);
            });
        }
    }
}

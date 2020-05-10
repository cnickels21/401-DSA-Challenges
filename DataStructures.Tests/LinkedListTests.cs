using Xunit;

namespace DataStructures.Tests
{
    public class LinkedListTests
    {

        /*
        1. Can successfully instantiate an empty linked list -- DONE
        2. Can properly insert into the linked list -- DONE
        3. The head property will properly point to the first node in the linked list --  DONE
        4. Can properly insert multiple nodes into the linked list
        5. Will return true when finding a value within the linked list that exists
        6. Will return false when searching for a value in the linked list that does not exist
        7. Can properly return a collection of all the values that exist in the linked list
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
            listToAddTo.Insert(1, listToAddTo);

            // Assert
            Assert.Equal("4", listToAddTo.ToString());
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(1, "4")]
        public void Can_point_to_head_node(int initialInsertion, string expected)
        {
            // Arrange
            LinkedList listToAccessHead = new LinkedList();
            listToAccessHead.Insert(initialInsertion, listToAccessHead);

            // Act
            string result = listToAccessHead.ToString();

            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Can_insert_multiple_values()
        {
            // Arrange
            LinkedList listToPopulate = new LinkedList();
            int value = 1;

            // Act
            listToPopulate = listToPopulate.Insert(value, listToPopulate);

            // Assert
            Assert.Equal("4, 3, 2, 1, ", listToPopulate.StringifyFullList());

        }
    }
}

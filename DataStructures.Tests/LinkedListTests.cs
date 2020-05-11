using Xunit;

namespace DataStructures.Tests
{
    public class LinkedListTests
    {

        /*
        1. Can successfully instantiate an empty linked list -- DONE
        2. Can properly insert into the linked list -- DONE
        3. The head property will properly point to the first node in the linked list --  DONE
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
            listToAddTo.Insert(1, listToAddTo);

            // Assert
            Assert.Equal("{1} -> NULL", listToAddTo.ToString());
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

        // This test technically proves that I can insert multiple values and return all of the values from a list stringified
        [Fact]
        public void Can_insert_multiple_values()
        {
            // Arrange
            LinkedList listToPopulate = new LinkedList();
            int value = 1;

            // Act
            listToPopulate.Insert(value, listToPopulate);

            // Assert
            Assert.Equal("4, 3, 2, 1, ", listToPopulate.StringifyFullList());
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(0, false)]
        [InlineData(null, false)]
        public void Can_check_for_value_in_list(int value, bool expected)
        {
            // Arrange
            LinkedList verificationList = new LinkedList();
            int insertion = 1;
            verificationList.Insert(insertion, verificationList);

            // Act
            bool result = LinkedList.Includes(value, verificationList);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

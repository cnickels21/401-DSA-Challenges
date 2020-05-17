using System;
using System.Text;
using Xunit;
using DataStructures.Stack;

namespace DataStructures.Tests.Stack.Tests
{
    public class StackTests
    {

        [Fact]
        public void Can_push_to_create_a_stack()
        {
            // Arrange
            Stack<int> testStack = new Stack<int>();

            // Act
            int result = testStack.Push(1);

            // Assert
            Assert.Equal(1, result);

        }
    }
}

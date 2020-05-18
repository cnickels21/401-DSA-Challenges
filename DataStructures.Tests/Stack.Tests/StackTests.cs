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

        [Fact]
        public void Can_peek_at_current_top_in_a_stack()
        {
            // Arrange
            Stack<int> testStack = new Stack<int>();
            testStack.Push(1);
            testStack.Push(2);

            // Act
            int result = testStack.Peek();

            // Assert
            Assert.Equal(2, result);

        }

        [Fact]
        public void Can_pop_top_off_the_pop_top()
        {
            // Arrange
            Stack<int> testStack = new Stack<int>();
            testStack.Push(1);
            testStack.Push(2);

            // Act
            int result = testStack.Pop();

            // Assert
            Assert.Equal(2, result);

        }

        [Fact]
        public void Pop_method_throws_exception_if_null()
        {
            // Arrange
            Stack<int> testStack = new Stack<int>();

            // Assert
            Assert.Throws<StackEmptyException>(() =>
            {
                // Act
                testStack.Pop();
            });
        }

        [Fact]
        public void Peek_method_throws_exception_if_null()
        {
            // Arrange
            Stack<int> testStack = new Stack<int>();

            // Assert
            Assert.Throws<StackEmptyException>(() =>
            {
                // Act
                testStack.Peek();
            });
        }

        [Fact]
        public void IsEmpty_returns_true_if_empty()
        {
            // Arrange
            Stack<int> testStack = new Stack<int>();

            // Act
            bool result = testStack.IsEmpty();

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void IsEmpty_returns_false_if_not_empty()
        {
            // Arrange
            Stack<int> testStack = new Stack<int>();
            testStack.Push(1);

            // Act
            bool result = testStack.IsEmpty();

            // Assert
            Assert.False(result);

        }

        [Fact]
        public void Can_pop_off_all_the_pop_tops()
        {
            // Arrange
            Stack<int> testStack = new Stack<int>();
            testStack.Push(1);
            testStack.Push(2);

            // Act
            testStack.Pop();
            int result = testStack.Pop();

            // Assert
            Assert.True(testStack.IsEmpty());
            Assert.Equal(1, result);

        }
    }
}

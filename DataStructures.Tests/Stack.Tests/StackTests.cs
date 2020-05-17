﻿using System;
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
            Assert.Equal(1, result);

        }
    }
}

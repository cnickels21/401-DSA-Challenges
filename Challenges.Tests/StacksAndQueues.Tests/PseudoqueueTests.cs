﻿using System;
using System.Text;
using Challenges.StacksAndQueues;
using DataStructures.Stack;
using Xunit;

namespace Challenges.Tests.StacksAndQueues.Tests
{
    public class PseudoqueueTests
    {

        [Fact]
        public void Can_enqueue_into_empty_queue()
        {
            // Arrange
            Pseudoqueue<int> testQueue = new Pseudoqueue<int>();

            // Act
            testQueue.Enqueue(1);

            // Assert
            Assert.Equal(1, testQueue.Peek());
        }

        [Fact]
        public void Can_enqueue_multiple_items()
        {
            // Arrange
            Pseudoqueue<int> testQueue = new Pseudoqueue<int>();

            // Act
            testQueue.Enqueue(1);
            testQueue.Enqueue(2);
            testQueue.Enqueue(3);

            // Assert
            Assert.Equal(1, testQueue.Peek());
        }
    }
}

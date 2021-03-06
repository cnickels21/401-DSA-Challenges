﻿using DataStructures.Queue;
using Xunit;

namespace DataStructures.Tests.Queue.Tests
{
    public class QueueTests
    {

        [Fact]
        public void Peek_throws_empty_exception()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();

            // Assert
            Assert.Throws<QueueEmptyException>(() =>
            {
                // Act
                testQueue.Peek();
            });
        }

        [Fact]
        public void Enqueue_instantiates_new_queue_from_empty()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();

            // Act
            int result = testQueue.Enqueue(1);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Enqueue_adds_multiple_items_to_rear()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(1);

            // Act
            int result = testQueue.Enqueue(2);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Peek_at_front_value_of_queue()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(1);
            testQueue.Enqueue(2);

            // Act
            int result = testQueue.Peek();

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Dequeue_throws_empty_exception()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();

            // Assert
            Assert.Throws<QueueEmptyException>(() =>
            {
                // Act
                testQueue.Dequeue();
            });
        }

        [Fact]
        public void Dequeue_returns_value_of_dequeued_front_node()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(3);
            testQueue.Enqueue(2);
            testQueue.Enqueue(1);

            // Act
            int result = testQueue.Dequeue();

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Dequeue_returns_value_of_dequeued_front_node_on_queue_with_1_item()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(1);

            // Act
            int result = testQueue.Dequeue();

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Is_empty_true_if_empty_queue()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();

            // Act
            bool result = testQueue.IsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Is_empty_false_if_not_empty_queue()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(1);

            // Act
            bool result = testQueue.IsEmpty();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Dequeue_multiple_nodes_out_of_queue()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(3);
            testQueue.Enqueue(2);
            testQueue.Enqueue(1);

            testQueue.Dequeue();
            testQueue.Dequeue();
            testQueue.Dequeue();

            // Act
            bool result = testQueue.IsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Dequeue_throws_after_emptied()
        {
            // Arrange
            Queue<int> testQueue = new Queue<int>();
            testQueue.Enqueue(3);
            testQueue.Enqueue(2);
            testQueue.Enqueue(1);

            testQueue.Dequeue();
            testQueue.Dequeue();
            testQueue.Dequeue();

            // Assert
            Assert.Throws<QueueEmptyException>(() =>
            {
                // Act
                testQueue.Dequeue();
            });
        }

    }
}

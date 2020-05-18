using System;
using System.Text;
using Xunit;
using DataStructures.Queue;

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

    }
}

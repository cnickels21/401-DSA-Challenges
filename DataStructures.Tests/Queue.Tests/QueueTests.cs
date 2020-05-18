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

    }
}

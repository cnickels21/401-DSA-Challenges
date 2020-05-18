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
    }
}

using System;
using System.Text;
using Challenges.StacksAndQueues;
using Xunit;

namespace Challenges.Tests.StacksAndQueues.Tests
{
    public class MultiBracketValidationTests
    {
        [Theory]
        [InlineData("[")]
        [InlineData("{")]
        [InlineData("(")]
        public void Can_push_brackets_into_stack(string input)
        {
            // Arrange
            // Inline data

            // Act
            bool result = MultiBracketValidation.MixMatchTheSwitchCatch(input);

            Assert.True(result);
        }

    }
}

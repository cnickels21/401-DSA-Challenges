using System;
using System.Text;
using Challenges.StacksAndQueues;
using Xunit;

namespace Challenges.Tests.StacksAndQueues.Tests
{
    public class MultiBracketValidationTests
    {
        [Fact]
        public void Can_push_brackets_into_stack()
        {
            // Arrange
            string testing = "[,{,(";

            // Act
            bool result = MultiBracketValidation.MixMatchTheSwitchCatch(testing);

            Assert.True(result);
        }

    }
}

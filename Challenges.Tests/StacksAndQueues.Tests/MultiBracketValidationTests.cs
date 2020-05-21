using Challenges.StacksAndQueues;
using Xunit;

namespace Challenges.Tests.StacksAndQueues.Tests
{
    public class MultiBracketValidationTests
    {

        /// <summary>
        /// Theories for all true strings
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("[]")]
        [InlineData("{}")]
        [InlineData("()")]
        [InlineData("[()]")]
        [InlineData("{[()]}")]
        [InlineData("[]{}()")]
        [InlineData("[{}()]")]
        [InlineData("{[(abcd)]}")]
        [InlineData("(Goober)")]
        public void Can_return_true_for_all_combinations_of_valid_brackets(string input)
        {
            // Arrange
            // Inline data

            // Act
            bool result = MultiBracketValidation.MixMatchTheSwitchCatch(input);

            // Assert
            Assert.True(result);
        }

        /// <summary>
        /// Theories for all false strings
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("[")]
        [InlineData("{")]
        [InlineData("(")]
        [InlineData("]")]
        [InlineData(")")]
        [InlineData("}")]
        [InlineData("[)")]
        [InlineData("[[")]
        [InlineData("))")]
        [InlineData("[(])")]
        [InlineData("{[()}")]
        [InlineData("[{}")]
        [InlineData("")]
        public void Can_return_false_for_all_combinations_of_invalid_brackets(string input)
        {
            // Arrange
            // Inline data

            // Act
            bool result = MultiBracketValidation.MixMatchTheSwitchCatch(input);

            // Assert
            Assert.False(result);
        }
    }
}

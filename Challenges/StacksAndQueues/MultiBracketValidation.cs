using DataStructures.Stack;

namespace Challenges.StacksAndQueues
{
    public class MultiBracketValidation
    {

        public static bool MixMatchTheSwitchCatch(string bracketCheck)
        {
            // Base variables for method to utilize
            bool defaultReturn = false;
            Stack<char> frontBracketHolderStack = new Stack<char>();

            foreach (char character in bracketCheck.ToCharArray())
            {
                if (character == '[' || character == '{' || character == '(')
                {
                    frontBracketHolderStack.Push(character);
                }
                else if (character == ']' || character == '}' || character == ')')
                {
                    if (frontBracketHolderStack.IsEmpty())
                    {
                        defaultReturn = false;
                        break;
                    }
                    if (frontBracketHolderStack.Peek() == CheckForMatchingBracket(character))
                    {
                        frontBracketHolderStack.Pop();
                        defaultReturn = true;
                    }
                }
            }
            if (!frontBracketHolderStack.IsEmpty())
            {
                defaultReturn = false;
            }

            return defaultReturn;
        }

        public static char CheckForMatchingBracket(char bracket)
        {
            switch (bracket)
            {
                case ']':
                    return '[';
                case '}':
                    return '{';
                case ')':
                    return '(';
                default:
                    return ' ';
            }
        }
    }
}

using System;
using System.Text;
using DataStructures.Stack;

namespace Challenges.StacksAndQueues
{
    public class MultiBracketValidation
    {

        public static bool MixMatchTheSwitchCatch(string bracketCheck)
        {
            // Base variables for method to utilize
            bool defaultReturn = false;
            string[] arrayOfCharactersInString = bracketCheck.Split(",");
            Stack<string> frontBracketHolderStack = new Stack<string>();

            foreach (string character in arrayOfCharactersInString)
            {
                if (character == "[" || character == "{" || character == "(")
                {
                    frontBracketHolderStack.Push(character);
                    if (frontBracketHolderStack.Peek() == "[")
                    {
                        defaultReturn = true;
                    }
                }
            }

            return defaultReturn;
        }
    }
}

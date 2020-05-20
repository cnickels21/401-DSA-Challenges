using System;

namespace Challenges.StacksAndQueues
{
    public class Cat : Animal
    {
        public override string Type
        {
            get => "cat";
            set => throw new NotImplementedException();
        }
    }
}

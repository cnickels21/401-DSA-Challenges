using DataStructures;
using System;

namespace Challenges
{
    public class LinkedListChallenges
    {
        public static LinkedList MergeLists(LinkedList listOne, LinkedList listTwo)
        {
            LinkedList.Node firstCurrent = listOne.Head;
            LinkedList.Node secondCurrent = listTwo.Head;

            if (firstCurrent == null || secondCurrent == null)
                throw new NullReferenceException("You didn't give me a list to merge!");

            // Capturing the present next nodes for use on each iteration
            LinkedList.Node firstListsNextNode = firstCurrent.Next;
            LinkedList.Node secondListsNextNode = secondCurrent.Next;

            // We're going down a rabbit hole
            while (firstCurrent.Next != null)
            {
                // Capturing each list's next node for use on this iteration
                firstListsNextNode = firstCurrent.Next;
                secondListsNextNode = secondCurrent.Next;

                // Insert second lists current node into next slot in first list
                // DON'T CHANGE -- okay, maybe needs to change for more edge cases
                secondCurrent.Next = firstCurrent.Next;
                firstCurrent.Next = secondCurrent;

                // Step over in first list to carry on
                firstCurrent = firstListsNextNode;

                // Step over in second list to carry on
                secondCurrent = secondListsNextNode;

                // Edge cases for breaking loop
                if (firstCurrent == null)
                {
                    firstCurrent.Next = secondCurrent;
                    secondCurrent = secondCurrent.Next;

                    if (secondCurrent == null)
                    {
                        break;
                    }
                }
                else if (secondCurrent == null)
                {
                    firstCurrent = firstCurrent.Next;
                    if (firstCurrent == null)
                    {
                        break;
                    }
                }
            }

            return listOne;
        }
    }
}

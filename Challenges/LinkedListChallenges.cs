using DataStructures;
using System;
using System.Text;
using System.Xml;

namespace Challenges
{
    public class LinkedListChallenges
    {
        public static LinkedList MergeLists(LinkedList listOne, LinkedList listTwo)
        {
            LinkedList.Node firstCurrent = listOne.Head;
            LinkedList.Node secondCurrent = listTwo.Head;

            while (firstCurrent.Next != null)
            {
                // Insert second lists current node into next slot in first list
                // DON'T CHANGE
                secondCurrent.Next = firstCurrent.Next;
                firstCurrent.Next = secondCurrent;

                // Step over in first list to carry on
                firstCurrent = firstCurrent.Next.Next;

                // Step over in second list to carry on
                secondCurrent = secondCurrent.Next;

                // Edge cases for breaking loop
                if (firstCurrent == null)
                {
                    firstCurrent.Next = secondCurrent;
                    secondCurrent = secondCurrent.Next;
                    
                    if (secondCurrent.Next == null)
                    {
                        break;
                    }
                }
                else if (secondCurrent == null)
                {
                    firstCurrent = firstCurrent.Next;
                    if (firstCurrent.Next == null)
                    {
                        break;
                    }
                }

                


                
            }

            return listOne;
        }
    }
}

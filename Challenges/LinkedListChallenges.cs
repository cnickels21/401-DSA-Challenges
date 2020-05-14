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
                secondCurrent.Next = firstCurrent.Next;
                firstCurrent.Next = secondCurrent;

                if (firstCurrent.Next == null)
                {
                    firstCurrent.Next = secondCurrent;
                    secondCurrent = secondCurrent.Next;
                    
                    if (secondCurrent.Next == null)
                    {
                        break;
                    }
                }
                else if (secondCurrent.Next == null)
                {
                    firstCurrent = firstCurrent.Next;
                    if (firstCurrent.Next == null)
                    {
                        break;
                    }
                }
                
                

                firstCurrent = firstCurrent.Next.Next;
                // secondCurrent = secondCurrent.Next;
            }

            return listOne;
        }
    }
}

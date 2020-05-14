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

                firstCurrent = firstCurrent.Next.Next;
                secondCurrent = secondCurrent.Next;
            }

            return listOne;
        }
    }
}

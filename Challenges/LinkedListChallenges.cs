﻿using DataStructures;
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

            // Capturing the present next nodes for use on each iteration
            LinkedList.Node firstListsNextNode = firstCurrent.Next;
            LinkedList.Node secondListsNextNode = secondCurrent.Next;

            while (firstCurrent.Next != null)
            {
                // Capturing each list's next node for use on this iteration
                firstListsNextNode = firstCurrent.Next;
                secondListsNextNode = secondCurrent.Next;

                // Insert second lists current node into next slot in first list
                // DON'T CHANGE
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

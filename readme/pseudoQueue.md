# Pseudo Queue

Create functional enqueue and dequeue methods for a pseudoqueue class within the C# .NET application designed for Data Structures and Algorithms.

## Challenge

Utilizing two stacks, create the internal functionality of a queue \(hence the pseudoqueue naming\).  The two stacks hold the values and allow you to enqueue and arrange the values in the correct order for the dequeue.

## Approach

My partner and I created a white board solution, utilizing visuals and wracking our brains together to approach our general solution.  The white board helped conceptualize it and I visualized it as playing the ring game where you have to move the rings to a different prong without putting a bigger ring on top of a smaller ring.  Take everything out of stack one and put them into stack two, put the new item into stack one, and then move everything back from stack two to stack one.  This allows enqueue to always put the new item at the bottom of stack one and the dequeue to return the first item that went in.  Below you will find the code and our white board diagram.

[Check the Code!](../Challenges/StacksAndQueues/Pseudoqueue.cs)

![White Board Solution](assets/pseudoQueueWhiteBoard.png)
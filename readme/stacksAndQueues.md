# Stacks and Queues

Stacks and queues are two different types of data structures whose functionality is based off of how linked lists work but act in more definitive ways.  With a stack, when you add a new item to the top of the stack, that is the only item you can access.  Then you can continue each next item in the stack as it goes down.  Adversely, queues are a data structure that allow you to add an item the rear of a list, but then when you access the data, you access the front of the list, similar to a conveyer belt where the first thing but on the belt is also the first thing taken off.

## Challenge

Create a new stack class and a new queue class, and then create the node classes necessary to work with stacks and queues.  After the generic classes are created, define the methods necessary to work with stacks and queues \(see below for a description of these methods\).

## Approach

I used TDD to define my classes and verify their proper functionality.  Through a series of unit tests I am able to definitively say that my stack class functions exactly how it is expected to, and the same is true for my queue class.

## My Methods

For a stack, there are four key methods to define for full functionality: Push, Pop, Peek, and IsEmpty.  The push method adds an item to the top of the stack while the pop methods takes an item off the top of the stack.  My push method returns the value of the new top node while my pop method returns the value of the item that was popped off the top.  My pop method alsow throws an exception if the stack is empty.  Peek allows me to simply see what the current top node's value is, but throws an exception if the stack is empty.  Finally, IsEmpty simply returns true if the stack is empty or false if it is not.

A queue is very similiar, only the methods are as follows: Enqueue, Dequeue, Peek, and IsEmpty.  Enqueue allows me to add a new value to the end of the queue \(or cafeteria line if you will\).  Dequeue, however, takes the item off the front of the list, meaning the first item that was put into the queue, no matter how many have been put into the queue since.  It also throws an empty exception if the queue is empty.  Peek, similiar to that of a stack, allows me to simply see what the value of the *first* node in the stack is.  Finally, IsEmpty does the exact same thing for a queue that it does for a stack.

[Check Out My Stack!](../DataStructures/Stack/Stack.cs)
[Next in Line? My Queue](../DataStructures/Queue/Queue.cs)
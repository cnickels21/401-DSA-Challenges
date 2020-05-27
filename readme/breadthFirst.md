# Breadth First Traversal

## Summary

There are many ways to traverse a binary tree and yield your results accordingly.  We have covered PreOrder, InOrder, and PostOrder up to this point, but now we will be creating a breadth first traversal for our binary tree.  This means that the return list will be in order of top down, left to right; first level will return all values, second level will return left first, then right, and so on for each subsequent level in the tree.

## Challenge

Given a binary tree, send the values of the nodes through a queue in order to return a list of the items in your tree in a breadth first traversal \(see summary for more detail on expected output\).

## Approach and Efficiency

My partner and I drew up a white board solution that summarizes our approach to a solution.  Our intention was to utilize a queue that the values from our tree will get pushed into a queue and returned in their respected order.  The big O notation for space is O\(n^2\) because each value in the tree will have to be duplicated into the queue; big O for time however is just O\(n\) as we only need to traverse the entire tree once, worst case scenario.  I utilized TDD to find a solution for this DSA, but thus far have not been successful.  I am utilizing an IEnumerable list and yield return to come to a solution, but I have found difficulty in traversing through the tree correctly.  The solution will be coming soon!

[Check the Code!](../DataStructures/BinaryTree.cs)

[White Board Solution](assets/breadthFirstWhiteboard.pdf)
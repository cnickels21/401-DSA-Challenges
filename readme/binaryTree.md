# Binary Tree

## Summary

A binary tree is a data structure that is populated by nodes.  It is structured like a family tree with parent nodes that have a child to the left and a child to the right.  When a tree reaches the end of its branches, those nodes are referred to as leaves.  My binary tree is generic, meaning that it works with any data type; strings, ints, etc.  My binary *search* tree allows me to add to a tree and check if a value exists in the tree.

## Challenge

Create a binary tree class that has three methods; PreOrder, InOrder, and PostOrder.  Then create a binary search tree class that inherits from your binary tree and allows you to add values to a binary tree and check if a tree contains a given vaue.

## Approach and Efficiency

I created my binary tree as a generic class, meaning that it works with any data type.  My binary search tree utilizes a generic constraint that catches a lot of edge cases and guarantees that a tree only consists of one data type.  Since C# is a strongly typed language, this is extremely valuable in data validation.  Also, the three methods in my binary tree class utilize "yield return" to perform their functionality, meaning that my methods returns an IEnumerable list of data type "T" in the desired order according to the expectation of the methods.  I utilized TDD to verify the functionality of my methods, although there are a few unique edge cases that still need to be considered and tested for.  Coming soon!

[Check the Code!](../DataStructures/BinaryTree.cs)
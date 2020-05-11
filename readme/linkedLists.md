# Linked Lists

Linked lists are a data structure that offer a more efficient big O notation for storing and accessing data in certain cases.  They live as a separate public class in your project so that they can be accessed across multiple files and used in different ways throughout your project.

## Challenge

This challenge was to structure and define our first linked list class and write a variety of methods to learn how to use them and work with them. The specific challenge was to create lists, insert new items at the beginning, access all of the values in a list, and check a list for whether a value exists in the list or not.

## Approach and Efficiency

Using TDD I was able to step through each individual function and break it down step by step until I was able to get every test passing.  I did however intentially have one test failing so that I could prove the point that I am in fact accessing the head of the list \(or the first item\node in the list\).  Most of my methods have a big O notation of O\(1\) meaning that they are as efficient as they can be, but a few of them have to iterate and sift through the entire list so they are a big O notation of O\(n\).  Typically with lists you will often find yourself in a position where this is the best you can do because you need to traverse through the entire list to reach your desired result.

## API

Firstly, there is a method that, if the list is empty, inserts the value into the list.  And then, if the value is less than 5, iterates through and inserts the new value + 1 into the head of the list, creating a descending ordered list.  There is also a built in Reverse method that I did not use here that would return that descending list in ascending order.  Next are my two methods for stringifying.  One is attached to a list and returns the head node of that list stringified, and the other is attached to a list and iterates through attaching each node's value to a designated string.  I split these methods up so as to keep pure methods for different instances throughout my testing.  Finally, there is my Inlcudes method, which iterates through a given list and checks if a value exists within it or not, returnin true if it does, or returning false if the value doesn't exist in the list or is null.
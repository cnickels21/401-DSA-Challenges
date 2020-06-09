# Insertion Sort

An insertion sort is a method that takes an array of unsorted data and returns that array properly sorted.  This is one of the more inefficient sort algorithms, but is still an algorithm that can sort data for you.  The concept is that, as it iterates through the given array, it also performs a loop that moves the current value until it is in the correct spot.  The reason it is inefficient is because it has to iterate through the array, *and* for each item in the array, has to perform a second loop in order to actually sort the data accordingly.  So the time efficiency is now O\(n^2\).

How it works is, it sets the first value as "sorted".  Then, for each subsequent value, it compares that value to the previous value until the previous value is less than the current value we are sorting.  It continues this process of looping inside a loop for each value in the array until every value has been properly sorted.  And so, given an array of \[2, 4, 3, 6, 1\], each iteration will produce the following results:

- \[2, 4, 3, 6, 1\]
- \[2, 3, 4, 6, 1\]
- \[2, 3, 4, 6, 1\]
- \[1, 2, 3, 4, 6\]

The algorithm sets the first value as sorted to start, and then steps through each value after that one at a time; performing a while loop until that value is finally larger than the value that precedes it within the array.  It is a relatively drawn out process as it needs to iterate through the array as a whole, and, worst case, needs to iterate for the length of the array for each item in the array; making this sort method a less than ideal situation for sorting data accordingly.

[Check the Code!](../../Challenges/Sorts/InsertionSort.cs)  
[Check the Tests!](../../Challenges.Tests/Sorts/InsertionSortTests.cs)
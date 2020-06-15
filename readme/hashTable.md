# Hash Table

## Summary

A hash table is a data structure that allows you to store key/value pairs in an array of "buckets" and easily and directly access those values using that key.  The concept is *hashing* the key into an ASCII integer of the given key.  Then, that value acts as the index of the array to store the value in.  It is called a hash *table* because each index in the array is a list of nodes in some fashion that is able to hold multiple values at the same index.  Hash tables are an extremely efficient data structure that we will talk about below.

## Challenge

My challenge here was to create a hash table of my own instead of using the built in generic hash table in the .NET framework.  I had to create a nested class to define the nodes that are being stored in my hash table, and I had to create specific field sets and a constructor that defines what my hash table needs in order to be instantiated.  From there I had to create methods for adding a key/value pair to the hash table, a boolean method that tells me whether a key exists within the hash table or not, a get method that retreives a value based on a given key, and a hashing method itself to create the ASCII code for a given key.

## Approach and Efficiency

I created my hashing method specifically for a hash table that has 99 buckets, simply to make arrangement and testing more manageable.  There was some small amount of setup and definition required when creating my hash table, but after I had the core pieces created I utilized TDD to verify that each of my methods are working as expected.  By implementing the red/green/refactor methodology, I was able to step through and create the necessary methods for a hard coded hash table.

A distinct selling point of hash tables is that the time efficiency for accessing and retreiving data is O\(1\) as you are able to directly access a specific index of the table directly instead of having to iterate through the table until the correct value is found.  There are a few ways to optimize the efficiency of a specific table by optimizing how the the GenerateHashCode method works and how it can be idealized for specific lengths and values.  This is a more advanced approach to hash tables, and not implemented here in mine, but they, as a data structure, offer an immense amount of efficiency in the world of data storage and the performance that comes with it.

[Check the Code!](../DataStructures/HashTable/HashTable.cs)  
[Check the Code!](../DataStructures.Tests/HashTable.Tests/HashTableTests.cs)
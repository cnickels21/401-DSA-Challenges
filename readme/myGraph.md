# My Graph

A graph is a linear data structure that allows you to insert nodes and make connections by defining neighbors of that node.  You can represent a graph through a binary matrix that describes each connection a node has, or through an adjacency list, which can be represented through a 2d array, or a list of lists potentially.  Graphs come in many shapes and forms, from directed to undirected, cyclic or acyclic, and a few other defining features of any given graph.  My graph here is is undirected and very simple in nature, but allows you to store values and make connections between them.

## Challenge

Create a graph data structure that can add vertices, add neighbors, get all nodes, get all neighbors, and count how many nodes are in the graph.

## Approach and Efficiency

After doing some auxiliary studying on how to implement a graph from scratch I was able to structure out my nested vertex class and create a field for my graph that captures and represents my graph through an adjacency list.  I then used TDD to red/green refactor my methods until they were working as expected and now have a very basic, but functional graph.  My methods, as defined, are of an O\(n\) time efficiency as they have to iterate through every index of my array of lists.  Potentially even O\(n ^ n\) because if a node has a connection to every single other node it might have to iterate through that full list as well, depending on what you want to do with my graph.

## API

### AddVertex\(\)

After a graph has been created of particular array size, this method adds a new vertex to the adjacency list that represents my graph.

### AddEdge\(\)

Within a graph that has multiple vertices, this method allows you to make a connection between two vertices.

### GetVertices\(\)

This method returns all of the vertices that are in a given graph.

### GetNeighbors\(\)

This returns a list starting with the given value, and then each subsequent value is a corresponding neighbor.

### Size\(\)

This method simply returns how many nodes are in the graph.
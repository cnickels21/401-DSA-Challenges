﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.Graph;
using System.Linq;

namespace DataStructures.Tests.Graph.Tests
{
    public class MyGraphTests
    {
        [Fact]
        public void Can_add_one_vertex_to_graph()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();

            // Act
            var result = testGraph.AddVertex(1).Value;

            // Assert
            Assert.Equal("1", result.ToString());
        }

        [Fact]
        public void Can_add_multiple_vertices_to_graph()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();

            // Act
            var first = testGraph.AddVertex(1);
            var second = testGraph.AddVertex(2);
            var third = testGraph.AddVertex(3);

            // Assert
            Assert.Contains(first, testGraph.GetVertices());
            Assert.Contains(second, testGraph.GetVertices());
            Assert.Contains(third, testGraph.GetVertices());

        }

        [Fact]
        public void Can_add_an_edge()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();
            var firstVertex = testGraph.AddVertex(1);
            var secondVertex = testGraph.AddVertex(2);

            // Act
            testGraph.AddEdge(firstVertex, secondVertex, 42);

            // Second arrange
            var actual = firstVertex.Neighbors.First();
            (MyGraph<int>.Vertex, int) expected = (secondVertex, 42);

            // Assert
            Assert.True(firstVertex.Neighbors.Count == 1);
            Assert.True(actual.Equals(expected));
        }

        [Fact]
        public void Can_get_all_of_the_vertices()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();

            testGraph.AddVertex(1);
            testGraph.AddVertex(2);
            testGraph.AddVertex(3);

            // Act
            var result = testGraph.GetVertices();

            // Assert
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void Can_get_all_of_the_neighbors()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();

            var first = testGraph.AddVertex(1);
            var second = testGraph.AddVertex(2);
            var third = testGraph.AddVertex(3);

            testGraph.AddEdge(first, second);
            testGraph.AddEdge(first, third);
            testGraph.AddEdge(second, third);

            // Act
            var result = testGraph.GetNeighbors(first);
            var secondResult = testGraph.GetNeighbors(second);

            // Assert
            Assert.True(result.Count() == 2);
            Assert.True(secondResult.Count() == 2);
        }

        [Fact]
        public void Can_get_count_of_graph()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();

            testGraph.AddVertex(1);
            testGraph.AddVertex(2);
            testGraph.AddVertex(3);

            // Act
            int result = testGraph.Size();

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Vertex_doesnt_exist_returns_null()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();
            MyGraph<int>.Vertex testVertex = new MyGraph<int>.Vertex(1);

            // Act
            var result = testGraph.BreadthFirst(testVertex);

            // Assert
            Assert.True(result.Count() == 0);
        }

        [Fact]
        public void Breadth_first_on_one_layer()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();

            var first = testGraph.AddVertex(1);
            var second = testGraph.AddVertex(2);
            var third = testGraph.AddVertex(3);

            testGraph.AddEdge(first, second);
            testGraph.AddEdge(first, third);

            // This is the order because my adjacency list adds new items to the beginning of each list
            int[] expected = new int[] { 1, 3, 2 };

            // Act
            var result = testGraph.BreadthFirst(first);

            // Assert
            Assert.Equal(expected, result.ToArray());

            // Why did having these tests break each other and my assert.equal
            // Assert.Contains(second.Value, result);
            // Assert.Contains(third.Value, result);
        }

        [Fact]
        public void More_complex_traversal()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();

            var first = testGraph.AddVertex(1);
            var second = testGraph.AddVertex(2);
            var third = testGraph.AddVertex(3);
            var fourth = testGraph.AddVertex(4);
            var fifth = testGraph.AddVertex(5);

            testGraph.AddEdge(first, second);
            testGraph.AddEdge(first, third);
            testGraph.AddEdge(second, fourth);
            testGraph.AddEdge(third, fifth);

            // This is the order because my adjacency list adds new items to the beginning of each list
            int[] expected = new int[] { 1, 3, 2, 5, 4 };

            // Act
            var result = testGraph.BreadthFirst(first);

            // Assert
            Assert.Equal(expected, result.ToArray());
        }

        [Fact]
        public void Directed_or_undirected_graph()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();

            var first = testGraph.AddVertex(1);
            var second = testGraph.AddVertex(2);

            // Act
            testGraph.AddEdge(first, second);

            var result = testGraph.GetNeighbors(second);

            // Assert
            Assert.Contains(first, result);
        }

        /// <summary>
        /// Direct Flight Tests Below
        /// </summary>
        [Fact]
        public void No_connections_returns_false()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();

            MyGraph<int>.Vertex first = testGraph.AddVertex(1);
            MyGraph<int>.Vertex second = testGraph.AddVertex(2);
            MyGraph<int>.Vertex[] testArray = 
                new MyGraph<int>.Vertex[] { first, second };

            // Act
            var result = testGraph.TrySumEdgeWeights(out _, testArray);

            // Assert
            Assert.False(result);
        }
    }
}

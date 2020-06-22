using System;
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
            var first = testGraph.AddVertex(1).Value;
            var second = testGraph.AddVertex(2).Value;
            var third = testGraph.AddVertex(3).Value;

            // Second arrange
            var expected = testGraph.AdjList.First().Value.ToString();

            // Assert
            Assert.True(testGraph.AdjList.Count == 3);
            Assert.Equal(expected, first.ToString());
        }

        [Fact]
        public void Can_add_an_edge()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>();
            var firstVertex = testGraph.AddVertex(1);
            var secondVertex = testGraph.AddVertex(2);

            // Act
            testGraph.AddEdge(firstVertex, secondVertex);

            // Second arrange
            int actual = firstVertex.Neighbors.First();

            // Assert
            Assert.True(firstVertex.Neighbors.Count == 1);
            Assert.Equal(2, actual);
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
            List<int> setup = new List<int>();

            MyGraph<int>.Vertex first = testGraph.AddVertex(1);
            MyGraph<int>.Vertex second = testGraph.AddVertex(2);
            MyGraph<int>.Vertex third = testGraph.AddVertex(3);

            testGraph.AddEdge(first, second);
            testGraph.AddEdge(first, third);

            setup.Add(1);
            setup.Add(2);
            setup.Add(3);

            // Act
            IEnumerable<int> result = testGraph.GetNeighbors(first);

            // Second arrange
            string actual = result.ToList().ToString();
            string expected = setup.ToString();

            // Assert
            Assert.Equal(expected, actual);
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
    }
}

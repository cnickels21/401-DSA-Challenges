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
            MyGraph<int> testGraph = new MyGraph<int>(20);

            // Act
            MyGraph<int>.Vertex result = testGraph.AddVertex(1);

            // Second arrange
            var expected = testGraph.AdjList[0].First().ToString();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expected, result.ToString());
        }

        [Fact]
        public void Can_add_multiple_vertices_to_graph()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>(20);

            // Act
            MyGraph<int>.Vertex first = testGraph.AddVertex(1);
            MyGraph<int>.Vertex second = testGraph.AddVertex(2);
            MyGraph<int>.Vertex third = testGraph.AddVertex(3);

            // Second arrange
            var expected = testGraph.AdjList[0].First().ToString();
            var expectedTwo = testGraph.AdjList[1].First().ToString();
            var expectedThree = testGraph.AdjList[2].First().ToString();

            // Assert
            Assert.Equal(expected, first.ToString());
            Assert.Equal(expectedTwo, second.ToString());
            Assert.Equal(expectedThree, third.ToString());
        }

        [Fact]
        public void Can_add_an_edge()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>(20);
            MyGraph<int>.Vertex firstVertex = testGraph.AddVertex(1);
            MyGraph<int>.Vertex secondVertex = testGraph.AddVertex(2);

            // Act
            testGraph.AddEdge(firstVertex, secondVertex);

            // Second arrange
            bool actual = testGraph.AdjList[0].Contains(secondVertex);

            // Assert
            Assert.True(actual);
        }
    }
}

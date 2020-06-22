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
        public void Can_add_an_edge()
        {
            // Arrange
            MyGraph<int> testGraph = new MyGraph<int>(20);
            MyGraph<int>.Vertex firstVertex = testGraph.AddVertex(1);
            MyGraph<int>.Vertex secondVertex = testGraph.AddVertex(2);

            // Act
            testGraph.AddEdge(firstVertex, secondVertex);

            // Second arrange
            string result = firstVertex.ToString();
            string expected = secondVertex.ToString();

            // Assert
            Assert.Equal(result, expected);
        }
    }
}

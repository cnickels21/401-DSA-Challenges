using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.Graph;

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

            // Assert
            Assert.NotNull(result);
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

            // Assert
            Assert.(testGraph);
        }
    }
}

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
            MyGraph<int> testGraph = new MyGraph<int>();

            // Act
            MyGraph<int>.Vertex result = testGraph.AddVertex(1);

            // Assert
            Assert.NotNull(result);
        }
    }
}

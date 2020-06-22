using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph
{
    public class MyGraph<T>
    {
        LinkedList<LinkedList<Vertex>> AdjList { get; set; }

        public Vertex AddVertex(T value)
        {
            return default;
        }

        public class Vertex
        {
            public T Value { get; set; }
            public T Neighbor { get; set; }

            public bool Visited { get; set; }
            public int Weight { get; set; }

            public Vertex(T value, T neighbor)
            {
                this.Value = value;
                this.Neighbor = neighbor;
                this.Visited = false;
                this.Weight = 0;
            }
        }
    }
}

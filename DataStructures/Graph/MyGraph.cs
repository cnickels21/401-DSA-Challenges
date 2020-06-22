using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph
{
    public class MyGraph<T>
    {
        

        public Vertex AddVertex(T value)
        {
            Vertex newVertex = new Vertex(value);
            //AdjacencyList newList = new AdjacencyList();

            //newList.AdjList.AddFirst(newVertex);

            return newVertex;
        }

        public class Vertex
        {
            public T Value { get; set; }
            public T Neighbor { get; set; }

            public bool Visited { get; set; }
            public int Weight { get; set; }

            public Vertex(T value)
            {
                this.Value = value;
                this.Neighbor = default(T);
                this.Visited = false;
                this.Weight = 0;
            }
        }

        public class AdjacencyList
        {
            public LinkedList<LinkedList<Vertex>> AdjList { get; set; }
        }
    }
}

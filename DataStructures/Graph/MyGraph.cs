using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Graph
{
    public class MyGraph<T>
    {
        public LinkedList<Vertex> AdjList { get; set; }

        public MyGraph()
        {
            AdjList = new LinkedList<Vertex>();
        }

        public Vertex AddVertex(T value)
        {
            Vertex newVertex = new Vertex(value);

            AdjList.AddFirst(newVertex);

            return newVertex;
        }

        public void AddEdge(Vertex main, Vertex neighbor)
        {
            // Potential for adding edge when vertex doesnt exist yet
            //if (!AdjList.Contains(main))
            //    AddVertex(main.Value);
            //if (!AdjList.Contains(neighbor))
            //    AddVertex(neighbor.Value);

            main.Neighbors.AddFirst(neighbor);
        }

        public IEnumerable<Vertex> GetVertices()
        {
            foreach (var item in AdjList)
                yield return item;
        }

        public IEnumerable<Vertex> GetNeighbors(Vertex request)
        {
            foreach (var item in request.Neighbors)
                yield return item;
        }

        public int Size()
        {
            return AdjList.Count;
        }

        public IEnumerable<T> BreadthFirst(Vertex start)
        {
            if (!GetVertices().Contains(start))
                yield break;

            Queue<Vertex> traversal = new Queue<Vertex>();
            traversal.Enqueue(start);
            start.Visited = true;

            while (traversal.Count > 0)
            {
                Vertex front = traversal.Dequeue();
                var neighbors = GetNeighbors(front);

                foreach (var item in neighbors)
                {
                    if (item.Visited == false)
                    {
                        item.Visited = true;
                        traversal.Enqueue(item);
                    }
                }

                yield return front.Value;
            }
        }

        public class Vertex
        {
            public T Value { get; set; }
            public LinkedList<Vertex> Neighbors { get; set; }
            public bool Visited { get; set; }
            public int Weight { get; set; }

            public Vertex(T value)
            {
                this.Value = value;
                this.Neighbors = new LinkedList<Vertex>();
                this.Visited = false;
                this.Weight = 0;
            }
        }
    }
}

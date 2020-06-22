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

            if (AdjList.Count == 0)
            {
                AdjList.AddFirst(newVertex);
            }
            else
            {
                AdjList.AddLast(newVertex);
            }

            return newVertex;
        }

        public void AddEdge(Vertex main, Vertex neighbor)
        {
            for (int i = 0; i < AdjList.Length; i++)
            {
                var current = AdjList[i].First();

                if (current == main)
                {
                    AdjList[i].AddLast(neighbor);
                    break;
                }
            }
        }

        public IEnumerable<T> GetVertices()
        {
            for (int i = 0; i < AdjList.Length; i++)
            {
                if (AdjList.ElementAt(i).Count == 0)
                {
                    continue;
                }
                else
                {
                    var current = AdjList[i].First();
                    yield return current.Value;
                }
            }
        }

        public IEnumerable<T> GetNeighbors(Vertex request)
        {
            for (int i = 0; i < AdjList.Length; i++)
            {
                // This method I don't think is working the correct way yet but this variable will be part of making it work
                // var current = AdjList[i].First();

                if (AdjList.ElementAt(i).Count == 0)
                {
                    continue;
                }
                else
                {
                    foreach (var item in AdjList[i])
                    {
                        yield return item.Value;
                    }
                }
            }
        }

        public int Size()
        {
            int count = 0;

            for (int i = 0; i < AdjList.Length; i++)
            {
                if (AdjList.ElementAt(i).Count == 0)
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }

            return count;
        }

        public class Vertex
        {
            public T Value { get; set; }
            public LinkedList<T> Neighbors { get; set; }
            public bool Visited { get; set; }
            public int Weight { get; set; }

            public Vertex(T value)
            {
                this.Value = value;
                this.Neighbors = new LinkedList<T>();
                this.Visited = false;
                this.Weight = 0;
            }
        }
    }
}

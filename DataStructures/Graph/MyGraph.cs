using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Graph
{
    public class MyGraph<T>
    {
        public LinkedList<Vertex>[] AdjList { get; set; }

        public MyGraph(int vertices)
        {
            AdjList = new LinkedList<Vertex>[vertices];

            for (int i = 0; i < AdjList.Length; i++)
            {
                AdjList[i] = new LinkedList<Vertex>();
            }
        }

        public Vertex AddVertex(T value)
        {
            Vertex newVertex = new Vertex(value);

            if (AdjList[0].Count == 0)
            {
                AdjList[0].AddFirst(newVertex);
            }
            else
            {
                for (int i = 0; i < AdjList.Length; i++)
                {
                    if (AdjList.ElementAt(i).Count == 0)
                    {
                        AdjList[i].AddFirst(newVertex);
                        break;
                    }
                }
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

        public IEnumerable<T> GetNeighbors()
        {
            for (int i = 0; i < AdjList.Length; i++)
            {
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
    }
}

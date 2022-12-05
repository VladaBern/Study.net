using System.Collections.Generic;
using System.Linq;

namespace HomeTask3
{
    internal class Graph
    {
        private HashSet<Vertex> graph = new HashSet<Vertex>();

        public void Add(params Vertex[] other)
        {
            foreach (var vertex in other)
                graph.Add(vertex);
        }

        public int Wave(Vertex from, Vertex to)
        {
            if (from == to)
                return 0;
            if (from.Vertices.Count == 0)
                return -1;

            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(from);

            while (queue.Count > 0)
            {
                Vertex vertex = queue.Dequeue();

                vertex.Number++;

                if (vertex == to)
                    break;

                foreach (var vrtx in vertex.Vertices)
                {
                    if (vrtx.Number == 0)
                    {
                        vrtx.Number = vertex.Number;
                        queue.Enqueue(vrtx);
                    }
                }
            }

            if (to.Number == 0)
                return -1;
            else
                return to.Number - 1;
        }
    }
}

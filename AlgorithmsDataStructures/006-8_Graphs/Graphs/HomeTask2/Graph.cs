using System.Collections.Generic;
using System.Linq;

namespace HomeTask2
{
    internal class Graph
    {
        private HashSet<Vertex> graph = new HashSet<Vertex>();

        public void Add(params Vertex[] other)
        {
            foreach (var vertex in other)
                graph.Add(vertex);
        }

        public IList<string> Wave(Vertex from, Vertex to)
        {
            if (from.Vertices.Count == 0)
                return null;

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
                return null;

            Stack<Vertex> stack = new Stack<Vertex>();
            Vertex current = to;

            while (current != from)
            {
                stack.Push(current);

                foreach (var neighbor in current.Vertices)
                {
                    if (neighbor.Number == current.Number - 1)
                    {
                        current = neighbor;
                        break;
                    }
                }
            }

            stack.Push(from);
            return stack.Select(x => x.Name).ToList();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace HomeTask4
{
    internal class Graph
    {
        private List<Vertex> vertices;

        public Graph(int count)
        {
            vertices = new List<Vertex>();

            for (int i = 1; i <= count; i++)
                vertices.Add(new Vertex(i));
        }

        public void AddEdge(int parent, int child)
        {
            vertices.First(x => x.Number == parent).AddChild(vertices.First(x => x.Number == child));
        }

        public IList<int> BuildSortResult()
        {
            List<int> result = new List<int>();

            while (vertices.Count > 0)
            {
                Vertex current = vertices[0];

                while (!current.IsFree)
                    current = current.GetFirstParent();

                current.Remove();
                vertices.Remove(current);
                result.Add(current.Number);
            }

            return result;
        }
    }
}

using System.Collections.Generic;

namespace HomeTask3
{
    internal class Vertex
    {
        private HashSet<Vertex> vertices = new HashSet<Vertex>();

        public Vertex(string name)
        {
            Name = name;
        }

        public HashSet<Vertex> Vertices => vertices;

        public void Add(params Vertex[] other)
        {
            foreach (var vertex in other)
                vertices.Add(vertex);
        }

        public int Number { get; set; }
        public string Name { get; }
    }
}

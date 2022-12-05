using System.Collections.Generic;

namespace HomeTask4
{
    internal class Vertex
    {
        public int Number { get; }
        private List<Vertex> parents = new List<Vertex>();
        private List<Vertex> children = new List<Vertex>();

        public Vertex(int number)
        {
            Number = number;
        }

        public bool IsFree => parents.Count == 0;

        public void AddChild(Vertex child)
        {
            children.Add(child);
            child.parents.Add(this);
        }

        public void Remove()
        {
            foreach (Vertex child in children)
            {
                child.parents.Remove(this);
            }
        }

        public Vertex GetFirstParent()
        {
            return parents[0];
        }
    }
}

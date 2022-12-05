using System;

namespace HomeTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            Vertex a = new Vertex("a");
            Vertex b = new Vertex("b");
            Vertex c = new Vertex("c");
            Vertex d = new Vertex("d");
            Vertex e = new Vertex("e");
            Vertex f = new Vertex("f");

            a.Add(b);
            b.Add(a, c);
            c.Add(b, d, e);
            d.Add(c, f);
            e.Add(c, f);
            f.Add(d, e);

            graph.Add(a, b, c, d, e, f);

            Console.WriteLine(graph.Wave(a, b));

            Console.ReadKey();
        }
    }
}

using System;

namespace HomeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vertEdge = Console.ReadLine().Split(' ');
            int vertices = Convert.ToInt32(vertEdge[0]);
            int edges = Convert.ToInt32(vertEdge[1]);

            Graph graph = new Graph(vertices);

            for (int i = 0; i < edges; i++)
            {
                var childPar = Console.ReadLine().Split(' ');
                var parent = Convert.ToInt32(childPar[0]);
                var child = Convert.ToInt32(childPar[1]);
                graph.AddEdge(parent, child);
            }

            Console.WriteLine(string.Join(", ", graph.BuildSortResult()));

            Console.ReadKey();
        }
    }
}

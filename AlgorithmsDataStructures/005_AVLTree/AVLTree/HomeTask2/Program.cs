using System;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Set tree1 = new Set();
            tree1.Add(7);
            tree1.Add(2);
            tree1.Add(3);
            tree1.Add(4);
            tree1.Add(5);

            Set tree2 = new Set();
            tree2.Add(4);
            tree2.Add(1);
            tree2.Add(7);
            tree2.Add(3);
            tree2.Add(2);
            tree2.Add(9);

            var dif = tree1.SymmetricDifference(tree2);

            foreach(int i in dif)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}

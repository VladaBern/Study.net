using System;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Add(6);
            tree.Add(9);
            tree.Add(1);
            tree.Add(28);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            tree.Add(4);
            tree.Add(19);
            tree.Add(1);

            foreach (var item in tree)
                Console.Write(item + " ");

            Console.WriteLine();
            Console.WriteLine($"Tree contains 6 : {tree.Contains(6)}");
            Console.WriteLine($"Tree contains 11 : {tree.Contains(11)}");

            Console.ReadKey();
        }
    }
}

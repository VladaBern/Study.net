using System;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> tree = new AVLTree<int>();
            tree.Add(5);
            tree.Add(8);
            tree.Add(2);
            tree.Add(4);

            tree.Remove(8);

            Console.ReadKey();
        }
    }
}

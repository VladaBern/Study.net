using System;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            LinkedList<int> instance = new LinkedList<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                instance.Add(arr[i]);
            }

            foreach (int i in instance)
                Console.Write(i + " ");

            Console.WriteLine();

            instance.RemoveEveryElement(5);

            foreach (int i in instance)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}

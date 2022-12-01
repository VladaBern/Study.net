using System;

namespace HomeTask1
{
    internal class Program
    {
        static int CountRoads(double[,] arr)
        {
            int result = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != 0)
                        result++;
                }
            }

            return result / 2;
        }

        static void Main(string[] args)
        {
            double[,] arr = new double[,]
            {
                { 0, 1, 0, 0, 1 },
                { 1, 0, 1, 1, 0 },
                { 0, 1, 0, 0, 1 },
                { 0, 1, 0, 0, 1 },
                { 1, 0, 1, 1, 0 }
            };

            Console.WriteLine($"There're {CountRoads(arr)} roads between citys");

            Console.ReadKey();
        }
    }
}

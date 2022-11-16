using System;

namespace HomeTask1
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        static int[] ShellSort(int[] array)
        {
            if (array.Length <= 1)
                throw new InvalidOperationException();

            var d = array.Length / 2;

            while (d >= 1)
            {
                for (int i = d; i < array.Length; i++)
                {
                    int j = i;

                    while (j >= d && array[j - d] > array[j])
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] array = { 69, 14, 3, 8, 74, 2, 6, 1, 43, 7 };

            Console.WriteLine("Array before sorting");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();

            array = ShellSort(array);

            Console.WriteLine("Array after Shell sorting");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}

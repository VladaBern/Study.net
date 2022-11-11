using System;
using System.Collections.Generic;

namespace HomeTask2
{
    internal class Program
    {
        static void Display(LinkedList<int> arr, string text)
        {
            Console.WriteLine(text);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            LinkedList<int> numbers = new LinkedList<int>(arr);
            Display(numbers, "Created list with 10 numbers");

            LinkedListNode<int> current = numbers.First;
            for (int i = 0; i < 4; i++)
                current = current.Next;

            numbers.AddAfter(current, 28);
            numbers.AddAfter(current, 36);
            numbers.AddAfter(current, 49);
            Display(numbers, "Added three numbers after 5");
           
            numbers.AddFirst(97);
            numbers.AddLast(50);
            Display(numbers, "Added first and last numbers");

            while (numbers.First != null)
                numbers.Remove(numbers.First);
            Display(numbers, "Removed all elements");

            Console.ReadKey();
        }
    }
}

using System;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue priorityQueue = new PriorityQueue();

            priorityQueue.Enqueue("Run 300 m", Priority.medium);
            priorityQueue.Enqueue("Lift 70 kg", Priority.high);
            priorityQueue.Enqueue("Do warm-up", Priority.high);
            priorityQueue.Enqueue("Drink protein", Priority.low);
            priorityQueue.Enqueue("Sleep enough", Priority.high);
            priorityQueue.Enqueue("Drink water", Priority.medium);
            priorityQueue.Enqueue("Do row", Priority.low);

            Console.WriteLine(priorityQueue.Count);
            Console.WriteLine();

            Console.WriteLine(priorityQueue.Peek());
            Console.WriteLine(priorityQueue.Count);
            Console.WriteLine();

            while (priorityQueue.Count > 0)
                Console.WriteLine(priorityQueue.Dequeue());

            Console.ReadKey();
        }
    }
}

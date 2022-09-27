using System;
using System.Threading;

namespace HomeTask1
{
    class Program
    {
        static int counter;
        static object block = new object();

        static void Method()
        {
            for (int i = 0; i < 10; ++i)
            {
                lock (block)
                {
                    counter++;
                    Console.WriteLine($"Counter = {counter} - thread {Thread.CurrentThread.GetHashCode()}");
                }
            }
        }

        static void Main()
        {
            var threads = new Thread[3];

            for (int i = 0; i < threads.Length; ++i)
                (threads[i] = new Thread(Method)).Start();

            for (int i = 0; i < threads.Length; ++i)
                threads[i].Join();

            Console.ReadKey();
        }
    }
}

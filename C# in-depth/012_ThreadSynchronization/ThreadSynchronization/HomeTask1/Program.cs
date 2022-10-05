using System;
using System.IO;
using System.Threading;

namespace HomeTask1
{
    internal class Program
    {
        static Semaphore pool;

        static void WriteLog(object name)
        {
            for (int i = 0; i < 1000; i++)
            {
                pool.WaitOne();
                File.AppendAllText("Content.log", $"{DateTime.Now} - {name} {Guid.NewGuid()}\n");
                pool.Release();
            }
            Console.WriteLine($"Thread {name} completed");
        }

        static void Main(string[] args)
        {
            pool = new Semaphore(1, 1);

            for (int i = 0; i < 6; i++)
            {
                new Thread(WriteLog).Start(i);
            }

            Console.ReadKey();
        }
    }
}

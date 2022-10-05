using System;
using System.Threading;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mutex mutex = new Mutex(false, "MyMutex");

            if (mutex.WaitOne(10) == true)
            {
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                mutex.ReleaseMutex();
            }
            else
            {
                return;
            }
        }
    }
}

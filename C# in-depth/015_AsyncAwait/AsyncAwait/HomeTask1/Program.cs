using System;
using System.Threading;
using System.Threading.Tasks;

namespace HomeTask1
{
    class MyClass
    {
        static int counter;
        static object block = new object();

        public void Operation()
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

        public async void OperationAsync()
        {
            await Task.Factory.StartNew(Operation);
        }
    }

    internal class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
            for (int i = 0; i < 3; i++)
            {
                my.OperationAsync();
            }

            Console.ReadKey();
        }
    }
}

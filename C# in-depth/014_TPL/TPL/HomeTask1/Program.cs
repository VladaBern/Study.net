using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000000];
            Random random = new Random();

            Parallel.For(0, array.Length, i => array[i] = random.Next());

            Stopwatch timer = new Stopwatch();

            timer.Start();
            var oddNumbers = array.AsParallel().Where(element => element % 2 != 0);
            timer.Stop();
            Console.WriteLine($"Parallel - {timer.ElapsedTicks}");
            timer.Reset();

            timer.Start();
            var odds = array.Where(element => element % 2 != 0);
            timer.Stop();
            Console.WriteLine($"Sequence - {timer.ElapsedTicks}");

            Console.ReadKey();
        }
    }
}

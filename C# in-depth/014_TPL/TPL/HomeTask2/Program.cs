using System;
using System.Threading.Tasks;
using System.IO;

namespace HomeTask2
{
    internal class Program
    {
        static void WriteToFile()
        {
            var array = new string[10000];
            Parallel.For(0, array.Length, i => array[i] = Guid.NewGuid().ToString());
            File.AppendAllLines("file1.txt", array);
            Console.WriteLine("First method completed");
        }

        static void WriteToFile2()
        {
            var array = new string[10000];
            Parallel.For(0, array.Length, i => array[i] = Guid.NewGuid().ToString());
            File.AppendAllLines("file2.txt", array);
            Console.WriteLine("Second method completed");
        }

        static void Main(string[] args)
        {
            Parallel.Invoke(WriteToFile, WriteToFile2);
            Console.WriteLine("Main ended");

            Console.ReadKey();
        }
    }
}

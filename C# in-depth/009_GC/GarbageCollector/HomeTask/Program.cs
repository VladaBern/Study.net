using MemoryInspector;
using System;
using System.Collections.Generic;

namespace HomeTask
{
    class Program
    {
        static void Main()
        {
            MemoryInspector.MemoryInspector memoryInspector = new MemoryInspector.MemoryInspector(200);
            List<int> list = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                list.Add(i);
            }

            Console.ReadKey();
        }
    }
}

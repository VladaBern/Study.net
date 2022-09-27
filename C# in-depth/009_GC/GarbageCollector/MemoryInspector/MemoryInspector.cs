using System;
using System.Diagnostics;
using System.Threading;

namespace MemoryInspector
{
    public class MemoryInspector
    {
        private int maxSize;
        private Timer timer;

        public MemoryInspector(int maxSize)
        {
            this.maxSize = maxSize;
            TimerCallback tm = new TimerCallback(CheckMemory);
            timer = new Timer(tm, null, 0, 5000);
        }

        public void CheckMemory(object obj)
        {
            var memory = GC.GetTotalMemory(true);

            if ((memory * 100 / maxSize) >= 95)
            {
                Trace.TraceWarning($"Memory is used {memory} byte. Limit of memory is {maxSize} byte");
            }
        }
    }
}

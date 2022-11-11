using System;
using System.Collections.Generic;

namespace HomeTask2
{
    enum Priority
    {
        high,
        medium,
        low
    }

    internal class PriorityQueue
    {
        private Queue<string>[] queues;

        public int Count
        {
            get
            {
                var result = 0;
                for (var i = 0; i < queues.Length; i++)
                    result += queues[i].Count;
                return result;
            }
        }

        public PriorityQueue()
        {
            queues = new Queue<string>[] { new Queue<string>(), new Queue<string>(), new Queue<string>() };
        }

        public void Enqueue(string value, Priority priority)
        {
            switch (priority)
            {
                case Priority.high:
                    {
                        queues[0].Enqueue(value);
                        break;
                    }
                case Priority.medium:
                    {
                        queues[1].Enqueue(value);
                        break;
                    }
                case Priority.low:
                    {
                        queues[2].Enqueue(value);
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public string Dequeue()
        {
            if (queues[0].Count > 0)
                return queues[0].Dequeue();
            if (queues[1].Count > 0)
                return queues[1].Dequeue();
            if (queues[2].Count > 0)
                return queues[2].Dequeue();

            throw new InvalidOperationException();
        }

        public string Peek()
        {
            if (queues[0].Count > 0)
                return queues[0].Peek();
            if (queues[1].Count > 0)
                return queues[1].Peek();
            if (queues[2].Count > 0)
                return queues[2].Peek();

            throw new InvalidOperationException();
        }
    }
}

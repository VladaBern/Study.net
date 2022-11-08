using System.Collections;
using System.Collections.Generic;

namespace HomeTask1
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }

    public class LinkedList<T> : IEnumerable<T>
    {
        LinkedListNode<T> head;
        LinkedListNode<T> tail;

        public void Add(T item)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(item);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public void RemoveEveryElement(int position)
        {
            if (position > 0)
            {
                int counter = 1;
                var current = head;
                LinkedListNode<T> previous = null;

                while (current != null)
                {
                    if (counter % position == 0)
                    {
                        if (previous == null)
                        {
                            head = head.Next;
                        }
                        else
                            previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }

                    current = current.Next;

                    if (previous == null)
                    {
                        if (current != head)
                            previous = head;
                    }
                    else
                    {
                        if (previous.Next != current)
                            previous = previous.Next;
                    }

                    counter++;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}

using System;

namespace HomeTask1
{
    internal class DynamicArr<T>
    {
        private T[] data;
        private int count;

        public DynamicArr() : this(4) { }
        public DynamicArr(int size)
        {
            data = new T[size];
            count = 0;
        }

        public int Count { get { return count; } }

        public int Capacity { get { return data.Length; } }

        private void ResizeIncrease()
        {
            int capacity = data.Length == 0 ? 4 : data.Length * 2;
            T[] newArr = new T[capacity];

            data.CopyTo(newArr, 0);

            data = newArr;
        }

        private void ResizeDecrease()
        {
            T[] newArr = new T[data.Length - 1];
            Array.Copy(data, 0, newArr, 0, count);
            data = newArr;
        }

        public bool IsFull()
        {
            return data.Length == count;
        }

        public void Add(T item)
        {
            if (this.IsFull())
                this.ResizeIncrease();

            data[count++] = item;
        }

        public void Insert(T item, int index)
        {
            if (index > count)
                throw new IndexOutOfRangeException();

            if (this.IsFull())
                this.ResizeIncrease();

            Array.Copy(data, index, data, index + 1, Count - index);
            data[index] = item;

            count++;
        }

        public void RemoveAt(int index)
        {
            int shiftStart = index + 1;

            if (shiftStart < count)
                Array.Copy(data, shiftStart, data, index, count - shiftStart);

            count--;
            data[count] = default(T);
            ResizeDecrease();
        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(item))
                {
                    RemoveAt(i);
                }
            }
        }
    }
}

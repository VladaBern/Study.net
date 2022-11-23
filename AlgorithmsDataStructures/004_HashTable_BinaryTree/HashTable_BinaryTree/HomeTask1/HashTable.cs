using System;
using System.Collections.Generic;

namespace HomeTask1
{
    internal class HashTable<TKey, TValue>
    {
        private LinkedList<HashTableItem<TKey, TValue>>[] items;
        private int capacity;
        private int size;
        private const double LOAD_FACTOR = 0.75;

        public HashTable(int capacity)
        {
            this.capacity = capacity;
            items = new LinkedList<HashTableItem<TKey, TValue>>[capacity]; 
        }

        public int Count { get { return size; } }

        private int Hash(TKey key)
        {
            return Math.Abs(key.GetHashCode() % capacity);
        }

        private double GetLoadFactor()
        {
            return size / capacity;
        }

        private void Resize()
        {
            capacity = capacity * 2 + 1;
            var oldArr = items;
            size = 0;
            items = new LinkedList<HashTableItem<TKey, TValue>>[capacity];

            foreach (var item in oldArr)
            {
                if (item != null)
                {
                    foreach (var pair in item)
                    {
                        if (pair != null)
                            Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (GetLoadFactor() >= LOAD_FACTOR)
                Resize();

            int index = Hash(key);

            if (items[index] == null)
                items[index] = new LinkedList<HashTableItem<TKey, TValue>>();

            var hashTableItem = new HashTableItem<TKey, TValue>(key, value);

            items[index].AddFirst(hashTableItem);
            size++;
        }

        public bool Remove(TKey key)
        {
            var index = Hash(key);

            if (items[index] == null)
                return false;

            foreach (var item in items[index])
            {
                if (item.Key.Equals(key))
                {
                    items[index].Remove(item);
                    size--;
                    return true;
                }
            }

            return false;
        }

        public TValue GetValue(TKey key)
        {
            var index = Hash(key);

            if (items[index] == null)
                throw new ArgumentOutOfRangeException(nameof(key));

            foreach (var item in items[index])
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }

            throw new ArgumentOutOfRangeException(nameof(key));
        }

        public List<TKey> GetKey()
        {
            List<TKey> result = new List<TKey>();

            foreach (var item in items)
            {
                if (item != null)
                {
                    foreach (var pair in item)
                    {
                        if (pair != null)
                            result.Add(pair.Key);
                    }
                }
            }

            return result;
        }

        public void Clear()
        {
            size = 0;
            items = new LinkedList<HashTableItem<TKey, TValue>>[capacity];
        }
    }
}

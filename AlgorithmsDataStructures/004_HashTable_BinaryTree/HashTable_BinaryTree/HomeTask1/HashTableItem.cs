namespace HomeTask1
{
    internal class HashTableItem<T, V>
    {
        public T Key { get; private set; }
        public V Value { get; private set; }

        public HashTableItem(T key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}

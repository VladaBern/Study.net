using System;
using System.Collections;
using System.Collections.Generic;
namespace HomeWork2
{
    internal class CitizensCollection : IEnumerable<Citizen>
    {
        List<Citizen> list = new List<Citizen>();

        public int Add(Citizen citizen)
        {
            if (list.Contains(citizen))
            {
                throw new InvalidOperationException("This item is already in the collection");
            }

            if (citizen is Pensioner)
            {
                int index = 0;

                for (; index < list.Count; index++)
                {
                    if (!(list[index] is Pensioner))
                        break;
                }
                list.Insert(index, citizen);
                return index + 1;
            }
            else
            {
                list.Add(citizen);
                return list.Count;
            }
        }

        public void Remove()
        {
            list.RemoveAt(0);
        }

        public void Remove(Citizen citizen)
        {
            list.Remove(citizen);
        }

        public bool Contains(Citizen citizen, out int index)
        {
            index = list.IndexOf(citizen);

            if (index == -1)
                return false;

            index++;
            return true;
        }

        public Citizen ReturnLast(out int index)
        {
            index = list.Count;

            if (list.Count == 0)
            {
                index = -1;
                return null;
            }                
            return list[list.Count - 1];
        }

        public void Clear()
        {
            list.Clear();
        }

        public IEnumerator<Citizen> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using System.Collections;
using System.Collections.Generic;

namespace ALevel_HW11
{
    public class CustomCollection<T> : IEnumerable<T>
    {
        private List<T> items;

        public CustomCollection()
        {
            items = new List<T>();
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Sort()
        {
            items.Sort();
        }

        public void SetDefaultAt(int index, T defaultValue)
        {
            if (index >= 0 && index < items.Count)
            {
                items[index] = defaultValue;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySample
{
    public class ChainedList2<T> : IList<T>
    {
        public ChainedList2()
        {

        }
        public ChainedList2(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Add(item);
            }
        }

        private class ChainedListItem
        {
            internal T? Value { get; set; }
            internal ChainedListItem? Next { get; set; }
        }
        private ChainedListItem? head;
        private int count;
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count { get => count; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

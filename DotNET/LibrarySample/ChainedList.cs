using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySample
{
    public class ChainedList<T> : IList<T>
    {
        public ChainedList()
        {

        }
        public ChainedList(IEnumerable<T> values, bool readOnlyCollection = false)
        {
            foreach (T value in values)
            {
                Add(value);
            }
            IsReadOnly = readOnlyCollection;
        }
        private class ChainedListItem
        {
            public ChainedListItem(T? value)
            {
                Value = value;
            }
            internal T? Value { get; set; }
            internal ChainedListItem? Next { get; set; }
        }
        private int count;
        private ChainedListItem? head;

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Count => count;
        public bool IsReadOnly { get; private set; }
        public void Add(T item)
        {
            if (IsReadOnly) throw new NotSupportedException("This collection is read only.");
            var newItem = new ChainedListItem(item);
            if (head == null) head = newItem;
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newItem;
            }
            count++;
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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySample
{
    public class LinkedList<T> : IList<T>
    {
        private class LinkedListItem
        {
            internal T? Value { get; set; }
            internal LinkedListItem? Next { get; set; }
        }

        private LinkedListItem? head;

        private LinkedListItem GetElement(int index)
        {
            LinkedListItem current = head;
            int i = 0;
            while (index != i++)
            {
                current = head.Next;
            }
            return current;
        }
        public T? this[int index] { get => GetElement(index).Value; set => GetElement(index).Value = value; }

        public int Count { get; private set; }

        public bool IsReadOnly => throw new NotImplementedException();

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

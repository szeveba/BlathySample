using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
            internal ChainedListItem(T? value)
            {
                Value = value;
            }
            internal T? Value { get; set; }
            internal ChainedListItem? Next { get; set; }
        }
        public int Count { get; private set; }
        private ChainedListItem? head;
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void Add(T item)
        {
            if (IsReadOnly) throw new InvalidOperationException("This collection is read only.");
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
            Count++;
        }

        public bool IsReadOnly { get; private set; }
        
        
        public void Clear()
        {
            var current = head;
            head = null;
            while (current != null)
            {
                var temp = current.Next;
                current.Next = null;
                current = temp;
            }
        }
        public bool Contains(T item)
        {
            var current = head;
            while (current != null)
            {
                if (current.Value == null)
                {
                    if (item == null) return true;
                }
                else
                {
                    if (current.Value.Equals(item)) return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        public int IndexOf(T item)
        {
            int i = 0;
            var current = head;
            while (current != null)
            {
                if (current.Value == null)
                {
                    if (item == null) return i;
                }
                else
                {
                    if (current.Value.Equals(item)) return i;
                }
                current = current.Next;
                i++;
            }
            return -1;
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

        }
        private ChainedListItem GetElementAt(int index)
        {
            CheckIndex(index);
            int i = 0;
            var current = head;
            while (i != index)
            {
                current = current!.Next;
            }
            return current!;
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || Count <= index) throw new IndexOutOfRangeException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                // yield egy 'sytax sugar', arra készteti a fordítót hogy generáljon egy osztályt a
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ChainedListEnumerator(head);
        }
        private class ChainedListEnumerator : IEnumerator<T?>
        {
            private ChainedList<T?>.ChainedListItem head;

            public ChainedListEnumerator(ChainedListItem? head)
            {
                this.head = head;
            }

            public T? Current { get; private set; }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}

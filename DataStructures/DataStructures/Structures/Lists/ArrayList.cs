using System;

namespace DataStructures.Structures.Lists
{
    public class ArrayList<T> : IArrayList<T>
    {
        private T[] _storage;
        private int _index = 0;
        public int Length => _storage.Length;
        public ArrayList(int length)
        {
            _storage = new T[length];
        }

        public void Add(T n)
        {
            _storage[_index] = n;
            _index++;
        }

        public T Get(int index)
        {
            return _storage[index];
        }

        public void Set(int index, T n)
        {
            if (index >= _storage.Length)
            {
                throw new IndexOutOfRangeException();
            }
            _storage[index] = n;
        }

        public void Print()
        {
            Console.Write(this);
        }

        public void Clear()
        {
            _storage = new T[_storage.Length - 1];
        }

        public int CountOccurences(T n)
        {
            int count = 0;
            foreach (var i in _storage)
            {
                if (i.Equals(n)) count++;
            }

            return count;
        }

        public override string ToString()
        {
            var s = "{";
            foreach (var i in _storage)
            {
                s += $"{i}, ";
            }
            s += '}';
            return s;
        }
    }
}
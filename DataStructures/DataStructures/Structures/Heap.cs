using System;

namespace DataStructures.Structures
{
    public enum HeapType
    {
        Min = 0,
        Max = 1
    }

    public class Heap<T> where T : IComparable<T>
    {
        private T[] _items = new T[50];
        private int _currentSize;
        private HeapType _type;

        public int Length => _currentSize;

        public Heap(HeapType type)
        {
            _type = type;
        }

        public void Add(T data)
        {
            int hole = ++_currentSize;
            for (; Compare(data, _items[hole / 2]) < 0 && hole > 1; hole /= 2)
            {
                _items[hole] = _items[hole / 2];
            }
            _items[hole] = data;
        }

        public T RemoveFirst()
        {
            T value = _items[1];
            T left = _items[2 * 1];
            T right = _items[2 * 1 + 1];
            T data = _items[_currentSize--];
            int hole = 1;
            if (_currentSize > 1)
            {
                if (Compare(left, right) < 0)
                {
                    for (; Compare(data, _items[hole * 2]) > 0 && hole * 2 < _currentSize; hole *= 2)
                    {
                        _items[hole] = _items[hole * 2];
                    }
                }
                else
                {
                    for (; Compare(data, _items[hole * 2 + 1]) > 0 && hole * 2 + 1<_currentSize ; hole *= 2 + 1)
                    {
                        _items[hole] = _items[hole * 2 + 1];
                    }
                }
            }

            _items[hole] = data;
            return value;
        }

        public T First()
        {
            return _items[1];
        }

        private int Compare(T input, T input2)
        {
            if (input2 == null)
            {
                return 0;
            }

            if (_type == HeapType.Min)
            {
                return input.CompareTo(input2);
            }
            if (_type == HeapType.Max)
            {
                return input2.CompareTo(input);
            }

            throw new ArgumentException("A heap type is required");
        }

        public override string ToString()
        {
            var str = "";
            for (var i = 1; i <= _currentSize; i++)
            {
                str += $"[ {_items[i]} ], ";
            }
            return str;
        }
    }
}
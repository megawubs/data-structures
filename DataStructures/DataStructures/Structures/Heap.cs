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
        private T[] _items;
        private int _currentSize;
        private HeapType _type;

        public int Length => _currentSize;

        public Heap(int capacity, HeapType type)
        {
            _type = type;
            _items = new T[capacity];
        }

        public Heap() : this(50, HeapType.Min)
        {

        }

        public Heap(int capacity) : this(capacity, HeapType.Min)
        {

        }

        public Heap(HeapType type) : this(50, type)
        {

        }

        public Heap(T[] items, HeapType type, int capacity) : this(capacity, type)
        {
            BuildHeap(items);
        }

        public void Add(T data)
        {
            if (_currentSize == _items.Length - 1)
            {
                Resize();
            }
            _currentSize = _currentSize + 1;
            int hole = _currentSize;
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
            T data = _items[_currentSize];
            _currentSize = _currentSize - 1;
            int hole = 1;
            // reorder stuff when there are more than 1 items
            if (_currentSize > 1)
            {
                //is left smaller than right? go left.
                if (Compare(left, right) < 0)
                {
                    for (; Compare(data, _items[hole * 2]) > 0 && hole * 2 < _currentSize; hole *= 2)
                    {
                        _items[hole] = _items[hole * 2];
                    }
                }
                //if left is bigger than right, go right
                else
                {
                    for (; Compare(data, _items[hole * 2 + 1]) > 0 && hole * 2 + 1<_currentSize ; hole *= 2 + 1)
                    {
                        _items[hole] = _items[hole * 2 + 1];
                    }
                }
            }
            //set the data
            _items[hole] = data;
            return value;
        }

        public T First()
        {
            return _items[1];
        }

        private int Compare(T input, T input2)
        {
            //when using HeapType.Max input2 can be null, check this first.
            if (input2 == null)
            {
                return 0;
            }

            //I know it works, but can't explain
            //has to do something with heaps and types
            //and compare and stuff
            if (_type == HeapType.Min)
            {
                return input.CompareTo(input2);
            }
            //assume HeapType.Max
            return input2.CompareTo(input);
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

        private void Resize()
        {
            var newList = new T[_items.Length * 2];
            for (var i = 0; i < _items.Length; i++)
            {
                newList[i] = _items[i];
            }

            _items = newList;
        }

        public Heap<T> Invert()
        {
            var type = _type == HeapType.Max ? HeapType.Min : HeapType.Max;

            var items = new T[_currentSize];
            for (int i = 1; i <= _currentSize; i++)
            {
                items[i -1 ] = _items[i];
            }
            return new Heap<T>(items, type, _items.Length);
        }

        public void BuildHeap(T[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Add(items[i]);
            }
        }
    }
}
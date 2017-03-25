using System;
using DataStructures.List;
using DataStructures.Structures.Lists;

namespace DataStructures.Structures.Queue
{
    public class ArrayListQueue<T> : IQueue<T>
    {
        private ArrayList<T> _items = new ArrayList<T>(5);

        private int _front;
        private int _back = -1;

        public void Enqueue(T data)
        {
            if (_back == _items.Length -1) //no more place at the end of the queue
            {
                var diference = _back - _front;
                if (diference == _back) //no more room! Lets expand
                {
                    Expand();
                }
                if (_front > 0) //there are places free at the front!
                {
                    _back = -1;
                }
                if (_front == _items.Length)
                {
                    _front = 0;
                }
            }
            else if (_back + 1 == _front && _back != -1) //No more room! Lets expand
            {
                Expand();

            }
            _back++;
            _items.Set(_back, data);
        }

        private void Expand()
        {
            Console.WriteLine("expanding!");
            var tempList = new ArrayList<T>(_items.Length * 3);
            if (_front < _back)
            {
                for (var i = 0; i < _items.Length; i++)
                {
                    tempList.Add(_items.Get(i));
                }
            }
            else if (_back < _front)
            {
                //magic!
                for (var i = _front; i < _items.Length; i++)
                {
                    tempList.Add(_items.Get(i));
                }
                for (var j = 0; j <= _back; j++)
                {
                    tempList.Add(_items.Get(j));
                }

                _back = _items.Length - 1;
                _front = 0;
            }
            _items = tempList;
        }

        public T Dequeue()
        {
            if (_front == _items.Length -1 )
            {
                if (_back < _front)
                {
                    _front = 0;
                }
                if (_back == _front)
                {
                    _back = -1;
                    _front = 0;
                    return _items.Get(_items.Length - 1);
                }
            }

            if (IsFree(_front))
            {
                throw new IndexOutOfRangeException();
            }
            if (_back == _front)
            {
                _back--;
                return _items.Get(_front);
            }
            _front++;
            return _items.Get(_front - 1);
        }

        public T Front()
        {
            return _items.Get(_front);
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var s = "{";
            for(var i = 0; i < _items.Length; i++)
            {
                var empty = "x";
                var val = _items.Get(i);
                var value = val != null ? $"{_items.Get(i)}" : empty;
                if (i == _front)
                {
                    value = $"*{value}*";
                }
                if (i == _back)
                {
                    value = $"_{value}_";
                }

                s += IsFree(i) ? empty : value;
                s += " ";
            }
            s += '}';
            return s;
        }

        private bool IsFree(int index)
        {
            if (_back == -1 && _front == 0)
            {
                return true;
            }
            if (_back == _front)
            {
                return index != _back;
            }
            if (_back > _front)
            {
                return index < _front;
            }
            if (_front == _items.Length && _back == _items.Length - 1)
            {
                return true;
            }
            return index > _back && index < _front;
        }
    }
}
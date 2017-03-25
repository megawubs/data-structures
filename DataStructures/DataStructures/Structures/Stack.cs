using System;

namespace DataStructures.Structures
{
    public interface IStack<T>
    {
        void Push(T data);
        T Pop();
        T Top();
        Boolean Empty();
    }

    public class Stack<T> : IStack<T>
    {
        private T[] _list;
        private int _top = -1;

        public Stack()
        {
            _list = new T[30];
        }

        public void Push(T data)
        {
            _top++;
            if (_top >= _list.Length)
            {
                Expand();
            }
            _list[_top] = data;
        }

        private void Expand()
        {
            var list = new T[_list.Length * 2];
            Array.Copy(_list, list, _list.Length);
            _list = list;
        }

        public T Pop()
        {
            if (_top == -1)
            {
                throw new IndexOutOfRangeException();
            }
            _top--;
            return _list[_top + 1];
        }

        public T Top()
        {
            return _list[_top];
        }

        public bool Empty()
        {
            return _top == -1;
        }

        public override string ToString()
        {
            var line = "";
            for (var i = _top; i >= 0; i--)
            {
                line += _list[i] + " | ";
            }
            return line;
        }
    }
}
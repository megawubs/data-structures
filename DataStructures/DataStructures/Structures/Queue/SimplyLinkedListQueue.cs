using DataStructures.List;
using DataStructures.Structures.Lists;

namespace DataStructures.Structures.Queue
{
    public class SimplyLinkedListQueue<T> : IQueue<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();
        private int _length;
        public void Enqueue(T data)
        {
            _list.Insert(_length, data);
            _length++;
        }

        public T Dequeue()
        {
            var node = _list.First();
            _list.RemoveFirst();
            _length--;

//            var next = node.Next;
//            _list.Header.Next = next;

            return node.Data;
        }

        public T Front()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            var s = "{";
            var node = _list.First();
            while (node != null)
            {
                var data = node.Data.ToString();
                if (node == _list.First())
                {
                    data = $"*{data}*";
                }
                if (node == _list.Tail)
                {
                    data = $"_{data}_";
                }
                s += $"{data} ";
                node = node.Next;
            }
            s += "}";
            return s;
        }

        public bool IsEmpty()
        {
            return _length == 0;
        }
    }
}
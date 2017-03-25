using DataStructures.Structures.Lists;
using DataStructures.Structures.Queue;

namespace DataStructures.List
{
    public class SimpleLinkedPriorityQueue : IPriorityQueue<int>
    {
        private DoubleLinkedList<int> _queue = new DoubleLinkedList<int>();

        private DoubleLinkedNode<int> _min;

        public void Insert(int element)
        {
            _queue.Add(element);
        }

        public int FindMin()
        {
            if (_min != null)
            {
                return _min.Data;
            }
            var node = _queue.First();
            _min = node;
            node = node.Next;
            while (node != null)
            {
                if (node.Data < _min.Data && node != _queue.End)
                {
                    _min = node;
                }
                node = node.Next;
            }
            return _min.Data;
        }

        public void DeleteMin()
        {
            FindMin();
            var prev = _min.Previous;
            var next = _min.Next;
            prev.Next = next;
            next.Previous = prev;
            _min = null;
        }
    }
}
using System;
using DataStructures.List;
using DataStructures.Structures.Queue;

namespace DataStructures.Structures
{
    public class PriorityQueue<T> : IQueue<T> where T : IComparable<T>
    {
        private Heap<T> _heap;

        public PriorityQueue(HeapType type)
        {
            _heap = new Heap<T>(type);
        }

        public void Enqueue(T data)
        {
            _heap.Add(data);
        }

        public T Dequeue()
        {
            return _heap.RemoveFirst();
        }

        public T Front()
        {
            return _heap.First();
        }

        public bool IsEmpty()
        {
            return _heap.Length == 0;
        }

        public override string ToString()
        {
            return _heap.ToString();
        }

    }
}
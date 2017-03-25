using System;
using DataStructures.List;

namespace DataStructures.Structures.Lists
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        public DoubleLinkedNode<T> Head;
        public DoubleLinkedNode<T> End;
        private int _length = -1;

        public int Length => _length  + 1;

        public DoubleLinkedList()
        {
            Head = new DoubleLinkedNode<T>();
            End = new DoubleLinkedNode<T>();
            Head.Next = End;
            End.Previous = Head;
        }

        public void AddFirst(T data)
        {
            Insert(0, data);
        }

        public void Clear()
        {
            Head = new DoubleLinkedNode<T>();
            End = new DoubleLinkedNode<T>();
            Head.Next = End;
            End.Previous = Head;
            _length = -1;
        }

        public void Print()
        {
            Console.WriteLine(this);
        }

        public void Insert(int index, T data)
        {
            if (index > _length + 1)
            {
                throw new IndexOutOfRangeException();
            }

            var current = Head;
            var currentIndex = 0;
            while (currentIndex < index)
            {
                current = current.Next;
                currentIndex++;
            }
            DoubleLinkedNode<T> node = new DoubleLinkedNode<T>(data);
            node.Next = current.Next;
            current.Next.Previous = node;
            current.Next = node;
            node.Previous = current;
            _length++;
        }

        public void RemoveFirst()
        {
            var next = Head.Next.Next;
            if (next == null) return;
            next.Previous = Head;
            Head.Next = next;
            _length--;
        }

        public void Add(T data)
        {
            var node = new DoubleLinkedNode<T>(data);
            End.Previous.Next = node;
            node.Previous = End.Previous;
            End.Previous = node;
            node.Next = End;
            _length++;
        }

        public DoubleLinkedNode<T> First()
        {
            return Head.Next;
        }

        public DoubleLinkedNode<T> Last()
        {
            return End.Previous;
        }

        public override string ToString()
        {
            var current = Head.Next;
            int i = 0;
            var result = "";
            while (current.Next != null)
            {
                result += " " + current;
                current = current.Next;
                i++;
            }
            return result;
        }
    }
}
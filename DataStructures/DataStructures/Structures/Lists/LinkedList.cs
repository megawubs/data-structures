using System;
using DataStructures.List;

namespace DataStructures.Structures.Lists
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public Node<T> Header;
        private int _length;
        public Node<T> Tail;

        public LinkedList()
        {
            Header = new Node<T>();
        }

        public void AddFirst(T data)
        {
            Insert(0, data);
        }

        public void Clear()
        {
            Header = new Node<T>();
            _length = 0;
        }

        public void Print()
        {
            var current = Header;
            while (current.Next != null)
            {
                current = current.Next;
                Console.Write("[ Data: {0} ] -> ", current.Data );
            }
            Console.Write(" ||");
        }

        public void Insert(int index, T data)
        {
            if (index > _length)
            {
                throw new IndexOutOfRangeException();
            }

            var current = Header;
            var currentIndex = 0;
            while (currentIndex < index)
            {
                current = current.Next;
                currentIndex++;
            }
            Node<T> node = new Node<T>(data);
            node.Next = current.Next;
            current.Next = node;
            if (index == _length)
            {
                Tail = node;
            }
            _length++;
        }

        public void RemoveFirst()
        {
            Header.Next = Header.Next.Next;
            _length--;
        }

        public void Add(T data)
        {
            Insert(_length, data);
        }

        public Node<T> First()
        {
            return Header.Next;
        }
    }
}
using System;
using DataStructures.List;
using DataStructures.Structures.Lists;

namespace DataStructures.Week2
{
    public class DoubleLinkedList : IRunner
    {
        public void Run()
        {
            var list = new DoubleLinkedList<int>();

            list.AddFirst(5);
            list.Add(5);
            list.AddFirst(4);
            list.AddFirst(7);
            list.RemoveFirst();
            list.Add(9);
            list.Add(10);
//            list.Print();
            list.Clear();
            list.Add(2);
            list.AddFirst(5);
//            list.RemoveFirst();
            list.Print();

        }
    }
}
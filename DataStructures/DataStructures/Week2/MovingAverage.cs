using System;
using DataStructures.List;
using DataStructures.Structures.Lists;
using DataStructures.Week1;

namespace DataStructures.Week2
{
    public class MovingAverage : IRunner
    {
        public void Run()
        {
            MyAlgorithms algorithms = new MyAlgorithms();
            var numbers = algorithms.MovingAverage(new[] {4, 5, 3, 2, 1, 1, 4, 8, 10, 12, 15, 18, 20}, 4);
            foreach (var number in numbers)
            {
                Console.Write("{0} | ", number);
            }
            Console.WriteLine("");
            var list = new DoubleLinkedList<int>();

            list.Add(4);
            list.Add(5);
            list.Add(3);
            list.Add(2);
            list.Add(1);
            list.Add(1);
            list.Add(4);
            list.Add(8);
            list.Add(10);
            list.Add(12);
            list.Add(15);
            list.Add(18);
            list.Add(20);
            var list2 = algorithms.MovingAverage(list, 4);
            var node = list2.First();
            while (node.Next != null)
            {
                 Console.Write("{0} | ", node.Data);
                node = node.Next;
            }
        }
    }
}
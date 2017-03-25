using System;
using System.Xml.Schema;
using DataStructures.List;
using DataStructures.Structures.Lists;
using DataStructures.Week1;

namespace DataStructures.Week2
{
    public class CumulativeSum : IRunner
    {
        public void Run()
        {
            var algorithms = new MyAlgorithms();
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2); //3
            list.Add(3); //6
            list.Add(4); //10
            list.Add(5); //15
            list.Add(6); //21
            list.Add(7); //28
            list.Add(8); //36
            list.Add(9); //45
            list.Add(10); //55
            list.RemoveFirst();

            var sum = algorithms.CumulativeSum(list, 8);
            Console.WriteLine(sum);
        }
    }
}
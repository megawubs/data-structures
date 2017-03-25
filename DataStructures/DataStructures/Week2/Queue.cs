using System;
using DataStructures.List;
using DataStructures.Structures.Queue;

namespace DataStructures.Week2
{
    public class Queue : IRunner
    {
        public void Run()
        {
            var queue = new ArrayListQueue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Enqueue("4");
            queue.Dequeue(); //1
            queue.Dequeue(); //2
            queue.Enqueue("5");
            queue.Enqueue("6");
            queue.Enqueue("7"); //what's this going to do?

            Console.WriteLine(queue.Dequeue()); //3
            Console.WriteLine(queue.Dequeue()); //4
            Console.WriteLine(queue.Dequeue()); //5
            Console.WriteLine(queue.Dequeue()); //6
            Console.WriteLine(queue.Dequeue()); //7
//            queue.Enqueue("7");

            Console.WriteLine(queue.Dequeue()); //7
//            queue.Enqueue("G");
//            queue.Dequeue(); //B
//            queue.Enqueue("H");
//            queue.Enqueue("I");
//            queue.Enqueue("J");
//            queue.Enqueue("K");
//            queue.Enqueue("L");
//            queue.Enqueue("M");
//            queue.Enqueue("N");
//            queue.Enqueue("O");
//            queue.Enqueue("P");
//            queue.Enqueue("Q");
//            queue.Dequeue(); //C
//            queue.Enqueue("R");
//            queue.Enqueue("S");
//            queue.Enqueue("T");
//            queue.Enqueue("U");
//            queue.Enqueue("V");
//            queue.Enqueue("W");
//            queue.Enqueue("X");
//            queue.Enqueue("Y");
//            queue.Enqueue("Z");
//            queue.Dequeue(); //D
            Console.WriteLine(queue);
//            Console.WriteLine(queue);
        }
    }
}
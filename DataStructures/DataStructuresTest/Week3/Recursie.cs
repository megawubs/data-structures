using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace DataStructuresTest.Week3
{
    [TestFixture]
    public class Recursie
    {
        [Test]
        public void it_works()
        {
            var rec = new DataStructures.Week3.Recursie();

            Assert.AreEqual(6, rec.sum(123));
            Assert.AreEqual(14, rec.sum(2525));
        }

        [Test]
        public void fibonacci_recursive()
        {
            var rec = new DataStructures.Week3.Recursie();
//            var stopwatch = new Stopwatch();
//
//            for (int i = 1; i <= 40; i++)
//            {
//                stopwatch.Start();
//                var res = rec.fibonacci(i);
//                stopwatch.Stop();
//                Console.WriteLine($"It took {stopwatch.ElapsedTicks} ticks to run rec.fibonacci({i}) //{res}");
//                stopwatch.Reset();
//            }
            Assert.AreEqual(102334155, rec.fibonacci(40));
        }

        [Test]
        public void fibonnacci_not_recursive()
        {
            var rec = new DataStructures.Week3.Recursie();
//            var stopwatch = new Stopwatch();
//
//            for (int i = 1; i <= 40; i++)
//            {
//                stopwatch.Start();
//                var res = rec.FibonacciNonRecursive(i);
//                stopwatch.Stop();
//                Console.WriteLine($"It took {stopwatch.ElapsedTicks} ticks to run rec.FibonacciNonRecursive({i}) //{res}");
//                stopwatch.Reset();
//            }
            Assert.AreEqual(102334155, rec.FibonacciNonRecursive(40));
        }

        [Test]
        public void test_f()
        {
            var rec = new DataStructures.Week3.Recursie();
            Assert.AreEqual(9, rec.f(5));
            Assert.AreEqual(12, rec.f(6));
            Assert.AreEqual(16, rec.f(7));
        }

        [Test]
        public void it_prints_forward()
        {
            var rec = new DataStructures.Week3.Recursie();
            Assert.AreEqual("3 4 5 6 7 8 9", rec.PrintForward(new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9}, 3));
        }

        [Test]
        public void it_prints_backwards()
        {
            var rec = new DataStructures.Week3.Recursie();
            Assert.AreEqual("9 8 7 6 5 4 3", rec.PrintBackward(new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9}, 3));
        }
    }
}
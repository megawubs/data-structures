using System;
using System.Diagnostics;

namespace DataStructures.Week1
{
    public class Complexity
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();
        private readonly MyAlgorithms _algorithms = new MyAlgorithms();

        public void MesureGetMax()
        {

            for (int i = 50; i <= 25600; i = i * 2)
            {
                var array = Random.DoubleArray(i, 1, 50);
                Console.WriteLine(i);
                _stopwatch.Start();
                for (int y = 0; y < i; y++)
                {
                    Random.GetMax(array);
                }
                _stopwatch.Stop();
                Console.WriteLine("{0} times in {1} ticks", i, _stopwatch.ElapsedTicks);
            }
        }

        public void MesureCumulativeSum()
        {
            for (int i = 50; i <= 500; i = i + 50)
            {
                var array = Random.IntArray(i, 1, 50);
                _stopwatch.Start();
                var index = Random.IntArray(1, 0, array.Length)[0];
                for (int y = 0; y < i; y++) //O(N2)
                {
                    _algorithms.CumulativeSum(array, index); //O(N)
                }
                _stopwatch.Stop();
                Console.WriteLine("{0},{1}", i, _stopwatch.ElapsedTicks);
                _stopwatch.Reset();
            }
        }

        public void MesureCulumativeSumV2()
        {
            for (int i = 100; i <= 500; i = i + 50)
            {
                var array = Random.IntArray(i, 1, 50);
                var index = Random.IntArray(1, 0, array.Length)[0];
                _stopwatch.Start();
                _algorithms.InitCumulativeSomV2(array);
                for (int y = 0; y < i; y++) //O(N)
                {
                    _algorithms.CumulativeSumV2(array, index); //O(1)
                }
                _stopwatch.Stop();
                Console.WriteLine("{0},{1}", i, _stopwatch.ElapsedTicks);
                _stopwatch.Reset();
            }
        }

        public void MesureMesureCumulativeSumAndMesureCulumativeSumV2()
        {
            for (int i = 50; i <= 25600; i = i * 2)
            {
                var array = Random.IntArray(i, 1, 50);
                var index = Random.IntArray(1, 0, array.Length)[0];

                _stopwatch.Start();
                _stopwatch.Stop();
                _stopwatch.Reset();
                _stopwatch.Start();
                for (int y = 0; y < i; y++) //O(N2)
                {
                    _algorithms.CumulativeSum(array, index); //O(N)
                }
                _stopwatch.Stop();
                Console.WriteLine("Number of loops: {0}. Elapsed Ticks: {1}. Index to sum to: {2}", i, _stopwatch.ElapsedTicks, index);
                _stopwatch.Reset();

                _stopwatch.Start();
                _algorithms.InitCumulativeSomV2(array);
                for (int y = 0; y < i; y++) //O(N)
                {
                    _algorithms.CumulativeSumV2(array, index); //O(1)
                }
                _stopwatch.Stop();
                Console.WriteLine("CumulativeSumV2: Number of loops: {0}. Elapsed Ticks: {1}. Index to sum to: {2}", i, _stopwatch.ElapsedTicks, index);
                _stopwatch.Reset();
            }
        }

        public void MesureMovingAverage()
        {
            var array = Random.IntArray(10, 1, 100);
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}, {1}", i, array[i]);
            }
            _algorithms.InitCumulativeSomV2(array);
            var movingAverage = _algorithms.MovingAverage(array, 7);
            Console.WriteLine("Result");
            for (var i = 0; i < movingAverage.Length; i++)
            {
                Console.WriteLine("{0}, {1}", i, movingAverage[i]);
            }
        }
    }
}
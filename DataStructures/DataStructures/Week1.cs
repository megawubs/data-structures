using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructures
{
    public class Week1
    {
        private int _number;
        private int _sum;
        private readonly Stopwatch _stopwatch = new Stopwatch();
        public Week1(int number)
        {
            _number = number;
            Console.WriteLine("N = " + _number);
            List<Func<int, int>> fragments = new List<Func<int, int>>
            {
                Fragment1,
                Fragment2,
                Fragment3,
                Fragment4,
                Fragment5,
                Fragment6,
                Fragment7,
                Fragment8
            };

            fragments.ForEach(Run);
            Console.WriteLine(_sum);
        }

        private int Fragment1(int n)
        {
            for( int i = 0; i < n; i++ )
                _sum++;
            return _sum;
        }

        private int Fragment2(int n)
        {
            for( int i = 0; i < n; i += 2 )
                _sum++;

            return _sum;
        }

        private int Fragment3(int n)
        {
            for( int i = 0; i < n; i++ )
                for( int j = 0; j < n; j++ )
                    _sum++;
            return _sum;
        }

        private int Fragment4(int n)
        {
            for( int i = 0; i < n; i++ )
                _sum++;
            for( int j = 0; j < n; j++ )
                _sum++;

            return _sum;
        }

        private int Fragment5(int n)
        {
            for( int i = 0; i < n; i++ )
                for( int j = 0; j < n * n; j++ )
                    _sum++;

            return _sum;
        }

        private int Fragment6(int n)
        {
            for( int i = 0; i < n; i++ )
                for( int j = 0; j < i; j++ )
                    _sum++;

            return _sum;
        }

        private int Fragment7(int n)
        {
            for( int i = 0; i < n; i++ )
                for( int j = 0; j < n * n; j++ )
                    for( int k = 0; k < j; k++ )
                        _sum++;

            return _sum;
        }

        private int Fragment8(int n)
        {
            for( int i = 1; i < n; i = i * 2 )
                _sum++;

            return _sum;
        }

        private void Run(Func<int, int> function)
        {
            Console.WriteLine("Running: " + function.Method);
            _stopwatch.Start();
            function(_number);
            Stop();
        }

        private void Stop()
        {
            _stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", _stopwatch.Elapsed);
            _stopwatch.Reset();
        }



    }
}
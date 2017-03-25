using System;

namespace DataStructures.Structures
{
    public class Hashing
    {
        private readonly int[] _table;

        public Hashing(int lenght)
        {
            if (IsPrime(lenght) == false)
            {
                throw new ArgumentException("only primes are allowed!");
            }
               _table = new int[lenght];
        }

        public int HashValue(int x)
        {
            return x % _table.Length;
        }

        public static bool IsPrime(int x)
        {
            if (x == 0 || x == 1)
            {
                return false;
            }
            if (x == 2)
            {
                return true;
            }

            for (int a = 2; a <= x / 2; a++)
            {
                if (x % a == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Generate a list of primes between two numbers
        /// </summary>
        /// <param name="from"></param>
        /// <param name="till"></param>
        /// <returns></returns>
        public int[] GeneraePrimes(int from, int till)
        {
            var primes = new int[till-from];
            var j = 0;
            for (var i = from; i <= till; i++)
            {
                if (IsPrime(i))
                {
                    primes[j] = i;
                    j++;
                }
            }

            var allPrimes = new int[j];
            for (var b = 0; b < j; b++)
            {
                allPrimes[b] = primes[b];
            }
            return allPrimes;
        }
    }
}
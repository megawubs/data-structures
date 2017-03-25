    using System;
    using System.Collections.Generic;

namespace DataStructures.Week3
{
    public class Recursie
    {
        public int sum(int n)
        {
            return n <= 0 ? 0 : n % 10 + sum(n / 10);
        }

        public int fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        public int FibonacciNonRecursive(int n)
        {
            int[] list = new int[n + 1];
            for (var i = 0; i <= n; i++)
            {
                if (i <= 1)
                {
                    list[i] = i;
                }
                else
                {
                    list[i] = list[i - 2] + list[i - 1];
                }
            }
            return list[n];
        }

        public int f(int n)
        {
            return n > 0 ? n + f(n - 2) : 0;
        }

        public string PrintForward(List<int> theList, int i)
        {
            if (i > theList.Count)
            {
                return "";
            }
            return (theList[i - 1]  + " " + PrintForward(theList, i + 1)).TrimEnd();
        }

        public string PrintBackward(List<int> theList, int i)
        {
            if (i > theList.Count)
            {
                return "";
            }
            return (PrintBackward(theList, i + 1) + " " + theList[i - 1]).TrimStart();
        }
    }
}
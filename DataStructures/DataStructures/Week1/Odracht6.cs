using System;

namespace DataStructures.Week1
{
    public class Odracht6
    {
        public void Run() {
            var sum = 0;
            var n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n * n; j++)
                {
                    sum += Functie(j);
                }
            }
            Console.WriteLine(sum);
        }

        int Functie(int x) {
            int iets = 0;
            for (int k = 1; k < x; k++)
            {
                iets += Functie2(k, x);
            }
            return iets;
        }

        int Functie2(int x, int y) {
            int iets = 0;
            Console.WriteLine("Functie2, x = {0}, y = {1}", x, y);
            for (int k = x; k < y; k = k * 3)
            {
                Console.WriteLine("Functie2 loop, k = {0}, y = {1}", k, y);
                iets++;
            }

            return iets;
        }
    }
}
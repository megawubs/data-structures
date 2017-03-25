using System;

namespace DataStructures.Week1
{
    public class FizzBuzz
    {
        public void Run(int times)
        {
            for (var i = 1; i <= times; i++)
            {
                if (i % 3 == 0 && i % 5 !=0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if(i % 3 != 0 && i % 5 != 0 && (i % 3 == 0 && i % 5 == 0) == false)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
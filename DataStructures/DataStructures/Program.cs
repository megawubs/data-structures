using System;
using System.Net;
using DataStructures.List;
using DataStructures.Structures.Graph;
using DataStructures.Structures.Lists;

namespace DataStructures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<IRunner> weeks = new LinkedList<IRunner>();
//            weeks.Add(new Week1.Runner());
//            weeks.Add(new Week2.Runner());
//               weeks.Add(new Week4.Runner());
            weeks.Add(new Runner());

            var runner = new RunsRunners(weeks);
            runner.Run();

        }
    }
}
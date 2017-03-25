using DataStructures.List;
using DataStructures.Structures.Lists;

namespace DataStructures.Week2
{
    public class Runner : IRunner
    {
        public void Run()
        {
            var assignments = new LinkedList<IRunner>();
//            assignments.Add(new SimpleArrayList());
//            assignments.Add(new LinkedList());
//            assignments.Add(new CumulativeSum());
//            assignments.Add(new MovingAverage());
//              assignments.Add(new DoubleLinkedList());
//            assignments.Add(new Stack()); // broken
            assignments.Add(new Queue());

            var runner = new RunsRunners(assignments);

            runner.Run();
        }
    }
}
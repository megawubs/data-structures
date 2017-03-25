using DataStructures.List;
using DataStructures.Structures.Lists;

namespace DataStructures
{
    public class RunsRunners : IRunner
    {
        private readonly ILinkedList<IRunner> _runners;

        public RunsRunners(ILinkedList<IRunner> runners)
        {
            _runners = runners;
        }

        public void Run()
        {
            var runner = _runners.First();
            while (runner != null)
            {
                runner.Data.Run();
                runner = runner.Next;
            }
        }
    }
}
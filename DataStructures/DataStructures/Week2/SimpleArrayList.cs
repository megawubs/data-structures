using DataStructures.List;
using DataStructures.Structures.Lists;

namespace DataStructures.Week2
{
    public class SimpleArrayList : IRunner
    {
        public void Run()
        {
            SimpleArrayListExample();

        }

        private void SimpleArrayListExample()
        {
            var list = new ArrayList<int>(10);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Print();
        }
    }
}
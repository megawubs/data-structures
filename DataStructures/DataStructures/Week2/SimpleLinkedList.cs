using DataStructures.List;
using DataStructures.Structures.Lists;

namespace DataStructures.Week2
{
    public class SimpleLinkedList : IRunner
    {
        public void Run()
        {
            LinkedList<string> list2 = new LinkedList<string>();
            list2.AddFirst("World");
            list2.AddFirst("Hello");
            list2.Insert(1, "Awesome");
            list2.RemoveFirst();

            list2.Print();
            list2.Clear();
            list2.Print();
        }
    }
}
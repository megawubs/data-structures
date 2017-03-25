namespace DataStructures.Structures.Lists
{
    public class DoubleLinkedNode<T>
    {
        public T Data;
        public DoubleLinkedNode<T> Next;
        public DoubleLinkedNode<T> Previous;

        public DoubleLinkedNode(){}

        public DoubleLinkedNode(T data)
        {
            Data = data;
        }

        public DoubleLinkedNode(T data, DoubleLinkedNode<T> next, DoubleLinkedNode<T> previous)
        {
            Next = next;
            Previous = previous;
            Data = data;
        }

        public override string ToString()
        {
            var next = Next?.Data.ToString() ?? "null";
            var previous = Previous?.Data.ToString() ?? "null";
            var value = $"| ({previous}) <- {Data} -> ({next}) ";

            return value;
        }
    }
}
namespace DataStructures.Structures.Lists
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(){}

        public Node(T data)
        {
            Data = data;
        }
    }
}
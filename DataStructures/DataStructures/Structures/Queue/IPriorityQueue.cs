namespace DataStructures.Structures.Queue
{
    public interface IPriorityQueue<T>
    {
        void Insert(T element);
        T FindMin();
        void DeleteMin();
    }
}
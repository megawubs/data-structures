using DataStructures.List;

namespace DataStructures.Structures.Lists
{
    public interface ILinkedList<T>
    {
        void AddFirst(T data); // voeg een item toe aan het begin van de lijst
        void Clear();
        void Print();
        void Insert(int index, T data); // voeg een item in op een bepaalde index (niet overschrijven!)
        void RemoveFirst(); // verwijder het eerste item T getFirst() // geeft het eerste item terug
        void Add(T data); //add a new item

        Node<T> First();
    }
}
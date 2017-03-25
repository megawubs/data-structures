namespace DataStructures.Structures.Lists
{
    public interface IArrayList<T>
    {
        void Add(T value); // toevoegen aan het einde van de lijst, mits de lijst niet vol is int get(int index); // haal de waarde op van een bepaalde index
        T Get(int index);
        void Set(int index, T n); // wijzig een item op een bepaalde index
        void Print(); // print de inhoud van de list
        void Clear(); // maak de list leeg
        int CountOccurences(T n); // tel hoe vaak het gegeven getal voorkomt
    }
}
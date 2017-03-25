using System.Collections.Generic;

namespace DataStructures.Universe
{
    public class HashSet<T> where T : new()
    {
        private T[] _table;

        public HashSet()
        {
            _table = new T[10];
        }

        public T Get(int index)
        {
            var key = HashIndex(index);
            var res =  _table[key];
            if (res == null)
            {
                res = new T();
                _table[key] = res;
            }
            return res;
        }

        private int HashIndex(int index)
        {
            return index % 10;
        }
    }
}
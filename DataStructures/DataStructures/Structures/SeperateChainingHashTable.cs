using System.Collections.Generic;

namespace DataStructures.Structures
{
    public class SeperateChainingHashTable
    {
        private List<int>[] _table;

        public SeperateChainingHashTable()
        {
            _table = new List<int>[10];
        }

        public void Add(int x)
        {
            var index = HashValue(x);
            if (_table[index] == null)
            {
                _table[index] = new List<int>();
            }
            _table[index].Add(x);
        }

        public void Remove(int x)
        {
            var index = HashValue(x);
            _table[index].Remove(x);
        }

        public int HashValue(int x)
        {
            return x % _table.Length;
        }

        public override string ToString()
        {
            var str = "";
            for (var i = 0; i < _table.Length; i++)
            {
                str += $"{i}: \t";
                if (_table[i] != null)
                {
                    for (var i1 = 0; i1 < _table[i].Count; i1++)
                    {
                        str += $"{_table[i][i1]} -> ";
                    }
                    str += "||";
                }
                else
                {
                    str += "null";
                }
                str += "\r\n";
            }

            return str;
        }
    }
}
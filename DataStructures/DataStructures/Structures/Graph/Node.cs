using System;
using System.Collections.Generic;

namespace DataStructures.Structures.Graph
{
    public class Node : IComparable<Node>
    {
        public string Name { get; }

        public List<Edge> Adjacents = new List<Edge>();

        public int? Dist = null;

        public Node Prev;

        public bool Handled = false;

        public Node(string name)
        {
            Name = name;
        }

        public int CompareTo(Node other)
        {
            if (other == null)
            {
                return -1;
            }
            if (Dist == null)
            {
                return 1;
            }
            return (int)Dist?.CompareTo(other.Dist);
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
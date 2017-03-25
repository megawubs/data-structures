namespace DataStructures.Structures.Graph
{
    public class Edge
    {
        public Node Dest { get; set; }

        public int Cost { get; set; }

        public Edge(int cost)
        {
            Cost = cost;
        }

        public Edge(int cost, Node dest): this(cost)
        {
            Dest = dest;
        }

        public override string ToString()
        {
            return $" -> {Dest} (Cost: {Cost})";
        }
    }
}
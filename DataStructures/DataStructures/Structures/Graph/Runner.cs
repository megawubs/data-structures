namespace DataStructures.Structures.Graph
{
    public class Runner : IRunner
    {
        public void Run()
        {
            var graph = new Graph();

            var a = new Node("A");
            var b = new Node("B");
            var c = new Node("C");
            var d = new Node("D");
            var e = new Node("E");


            graph.AddEdge(a, b, 5);
            graph.AddEdge(a, c, 5);
            graph.AddEdge(c, b, 1);
            graph.AddEdge(a, d, 2);
            graph.AddEdge(d, c, 2);
            graph.AddEdge(b, d, 1);
            graph.AddEdge(d, e, 3);
            graph.AddEdge(e, a, 1);
            graph.AddEdge(a, e, 1);

//            Console.WriteLine(graph);
            graph.Unweighted(a);
            graph.PrintPath(c);
//            Console.WriteLine(" ");
            graph.Wheighted(a);
            graph.PrintPath(c);
        }
    }
}
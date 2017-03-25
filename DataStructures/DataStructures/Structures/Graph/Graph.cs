using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Structures.Graph
{
    public class Graph
    {
        public Dictionary<string, Node> Nodes = new Dictionary<string, Node>();

        public void AddEdge(Node sourceNode, Node destNode, int cost)
        {
            if (!Nodes.ContainsKey(sourceNode.Name))
            {
                Add(sourceNode);
            }
            if (!Nodes.ContainsKey(destNode.Name))
            {
                Add(destNode);
            }

            var edge = new Edge(cost, destNode);
            sourceNode.Adjacents.Add(edge);

        }

        public void Add(Node n)
        {
            Nodes.Add(n.Name, n);
        }

        public override string ToString()
        {
            var s = "";
            foreach (var keyValuePair in Nodes)
            {
                s += keyValuePair.Key + "\n\t";
                s+= String.Join(", \n\t", keyValuePair.Value.Adjacents);
                s += "\n\r";
            }

            return s;
        }

        public void Unweighted(Node startNode)
        {
            var start = ResetAndFindStart(startNode);

            var queue = new Queue<Node>();
            queue.Enqueue(start);
            start.Dist = 0;

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                foreach (var nodeAdjacent in node.Adjacents)
                {
                    var dest = nodeAdjacent.Dest;
                    if (dest.Dist == null)
                    {
                        dest.Prev = node;
                        dest.Dist = node.Dist + 1;
                        queue.Enqueue(dest);
                    }
                }
            }
        }

        public void PrintPath(Node dest)
        {
            if (dest.Prev != null)
            {
                PrintPath(dest.Prev);
                Console.WriteLine(" to ");
            }
            Console.WriteLine(dest);
        }

        public void Wheighted(Node startNode)
        {
            Node start = ResetAndFindStart(startNode);
            start.Dist = 0;
            var priorityQueue = new PriorityQueue<Node>(HeapType.Min);
            priorityQueue.Enqueue(start);

            while (priorityQueue.IsEmpty() == false)
            {
                var node = priorityQueue.Dequeue();

                if (node.Handled == false)
                {
                    foreach (var nodeAdjacent in node.Adjacents)
                    {
                        var dest = nodeAdjacent.Dest;

                        if (dest.Dist == null && dest.Prev == null)
                        {
                            dest.Prev = node;
                            dest.Dist = node.Dist + nodeAdjacent.Cost;
                            priorityQueue.Enqueue(dest);
                        }

                        if (dest.Dist > node.Dist + nodeAdjacent.Cost && node.Handled == false)
                        {
                            dest.Prev = node;
                            dest.Dist = node.Dist + nodeAdjacent.Cost;
                            priorityQueue.Enqueue(dest);
                        }

                        node.Handled = true;
                    }
                }
            }
        }


        public bool IsConnected()
        {
            if (Nodes.Count == 0)
            {
                return false;
            }

            if (Nodes.Count > 1)
            {
                Unweighted(Nodes.First().Value);
                foreach (var keyValuePair in Nodes)
                {
                    if (keyValuePair.Value.Prev == null)
                    {
                        return false;
                    }
                }
            }


            return true;
        }


        private Node ResetAndFindStart(Node startNode)
        {
            Node start = null;
            foreach (var keyValuePair in Nodes)
            {
                keyValuePair.Value.Prev = null;
                keyValuePair.Value.Dist = null;
                if (keyValuePair.Value.Equals(startNode))
                {
                    start = keyValuePair.Value;
                }
            }
            if (start == null)
            {
                throw new KeyNotFoundException($"Node with name {startNode} was not found");
            }
            return start;
        }
    }
}
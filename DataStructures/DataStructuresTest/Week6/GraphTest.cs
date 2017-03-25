using System.Collections.Generic;
using System.Linq;
using DataStructures.Structures.Graph;
using NUnit.Framework;

namespace DataStructuresTest.Week6
{
    [TestFixture]
    public class GraphTest
    {
        [Test]
        public void you_can_add_nodes_to_a_graph()
        {
            var graph = new Graph();

            var node = new Node("Ommen Station");

            graph.Add(node);

            var pair = new KeyValuePair<string, Node>(node.Name, node);
            Assert.Contains(pair, graph.Nodes);
        }

        [Test]
        public void you_can_add_edges_to_a_graph()
        {
            var graph = new Graph();

            var node = new Node("Station Ommen");
            var node2 = new Node("Station Zwolle");
            var node3 = new Node("Station Dalfsen");

            graph.Add(node);
            graph.Add(node3);
            graph.Add(node2);

            graph.AddEdge(node, node3, 1);
            graph.AddEdge(node2, node3, 1);

            Assert.AreEqual(1, node.Adjacents.Count);
            Assert.AreEqual(1, node2.Adjacents.Count);
        }

        [Test]
        public void it_can_find_a_wheighted_path()
        {
            var graph = new Graph();

            var a = new Node("A");
            var b = new Node("B");
            var c = new Node("C");

            graph.AddEdge(a, b, 3);
            graph.AddEdge(a, c, 1);
            graph.AddEdge(c, b, 1);

        }

        [Test]
        public void is_connected_works()
        {
            var graph = new Graph();

            Assert.IsFalse(graph.IsConnected());

            graph.AddEdge(new Node("A"), new Node("B"), 2);

            Assert.IsTrue(graph.IsConnected());
        }
    }
}
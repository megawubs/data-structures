using DataStructures.Structures.Graph;
using NUnit.Framework;

namespace DataStructuresTest.Week6
{
    [TestFixture]
    public class NodeTest
    {
        [Test]
        public void a_node_has_a_name()
        {
            var node = new Node("Ommen Station");

            Assert.AreEqual("Ommen Station", node.Name);
        }

        [Test]
        public void a_node_has_a_list_of_adjacents()
        {
            var node = new Node("Ommen Station");
            var node2 = new Node("Zwolle Station");
            var edge = new Edge(3, node2);
            node.Adjacents.Add(edge);

            Assert.Contains(edge, node.Adjacents);
        }
    }
}
using DataStructures.Structures.Graph;
using NUnit.Framework;

namespace DataStructuresTest.Week6
{
    [TestFixture]
    public class EdgeTest
    {
        [Test]
        public void an_edge_has_a_cost()
        {
            var edge = new Edge(2);

            Assert.AreEqual(2, edge.Cost);
        }

        [Test]
        public void an_edge_can_have_a_destination()
        {
            var dest = new Node("Haarlem");
            var edge = new Edge(3, dest);

            Assert.AreEqual(dest, edge.Dest);
        }
    }
}
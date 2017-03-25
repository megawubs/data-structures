using NUnit.Framework;

namespace DataStructuresTest.Week3
{
    [TestFixture]
    public class Faculteit
    {
        [Test]
        public void it_works_none_recursive()
        {
            var f = new DataStructures.Week3.Faculteit();
            Assert.AreEqual(120, f.NotRecursive(5));
        }

        [Test]
        public void it_works_recursive()
        {
            var f = new DataStructures.Week3.Faculteit();
            Assert.AreEqual(120, f.Recursive(5));
        }
    }
}
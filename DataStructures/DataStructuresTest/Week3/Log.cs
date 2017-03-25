using NUnit.Framework;

namespace DataStructuresTest.Week3
{
    [TestFixture]
    public class Log
    {
        [Test]
        public void log_of_10_is_3()
        {
            Assert.AreEqual(3, DataStructures.Week3.Log.Log2Floor(10));
        }

        [Test]
        public void log_of_10_is_3_recursive()
        {
            Assert.AreEqual(3, DataStructures.Week3.Log.Log2FloorRecursive(10));
        }
    }
}
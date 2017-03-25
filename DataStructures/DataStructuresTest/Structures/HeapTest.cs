using DataStructures.Structures;
using NUnit.Framework;

namespace DataStructuresTest.Structures
{
    [TestFixture]
    public class HeapTest
    {
        [Test]
        public void max_heap_works()
        {
            var heap = new Heap<string>(HeapType.Max);

            heap.Add("A");
            heap.Add("B");
            heap.Add("C");
            heap.Add("D");
            heap.Add("E");
            heap.Add("F");

            Assert.AreEqual("F", heap.RemoveFirst());
            Assert.AreEqual("E", heap.RemoveFirst());
            Assert.AreEqual("D", heap.RemoveFirst());
            Assert.AreEqual("C", heap.RemoveFirst());
            Assert.AreEqual("B", heap.RemoveFirst());
            Assert.AreEqual("A", heap.RemoveFirst());
        }

        [Test]
        public void min_heap_works()
        {
            var heap = new Heap<string>(HeapType.Min);

            heap.Add("F");
            heap.Add("E");
            heap.Add("D");
            heap.Add("C");
            heap.Add("B");
            heap.Add("A");

            Assert.AreEqual("A", heap.RemoveFirst());
            Assert.AreEqual("B", heap.RemoveFirst());
            Assert.AreEqual("C", heap.RemoveFirst());
            Assert.AreEqual("D", heap.RemoveFirst());
            Assert.AreEqual("E", heap.RemoveFirst());
            Assert.AreEqual("F", heap.RemoveFirst());
        }
    }
}
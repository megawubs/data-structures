using System.Runtime.InteropServices.ComTypes;
using DataStructures.Structures;
using NUnit.Framework;

namespace DataStructuresTest.Structures
{
    [TestFixture]
    public class HeapTest
    {
        [Test]
        public void max_heap_works_with_strings()
        {
            var heap = new Heap<string>(10, HeapType.Max);

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
        public void min_heap_works_with_strings()
        {
            var heap = new Heap<string>(10, HeapType.Min);

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

        [Test]
        public void min_heap_works_with_ints()
        {
            var heap = new Heap<int>(10);

            heap.Add(6);
            heap.Add(5);
            heap.Add(4);
            heap.Add(3);
            heap.Add(2);
            heap.Add(1);
            heap.Add(0);
            heap.Add(-1);

            Assert.AreEqual(-1, heap.RemoveFirst());
            Assert.AreEqual(0, heap.RemoveFirst());
            Assert.AreEqual(1, heap.RemoveFirst());
            Assert.AreEqual(2, heap.RemoveFirst());
            Assert.AreEqual(3, heap.RemoveFirst());
            Assert.AreEqual(4, heap.RemoveFirst());
            Assert.AreEqual(5, heap.RemoveFirst());
            Assert.AreEqual(6, heap.RemoveFirst());

        }

        [Test]
        public void max_heap_works_with_ints()
        {
            var heap = new Heap<int>(10, HeapType.Max);

            heap.Add(0);
            heap.Add(1);
            heap.Add(2);
            heap.Add(3);
            heap.Add(4);
            heap.Add(5);
            heap.Add(6);

            Assert.AreEqual(6, heap.RemoveFirst());
            Assert.AreEqual(5, heap.RemoveFirst());
            Assert.AreEqual(4, heap.RemoveFirst());
            Assert.AreEqual(3, heap.RemoveFirst());
            Assert.AreEqual(2, heap.RemoveFirst());
            Assert.AreEqual(1, heap.RemoveFirst());
            Assert.AreEqual(0, heap.RemoveFirst());
        }

        [Test]
        public void random_adding_and_removing_keeps_the_heap_in_tact()
        {
            var heap = new Heap<int>(10, HeapType.Min);

            heap.Add(0);
            Assert.AreEqual(0, heap.RemoveFirst());
            heap.Add(5);
            heap.Add(2);
            Assert.AreEqual(2, heap.RemoveFirst());
            heap.Add(10);
            heap.Add(4);
            heap.Add(49);
            Assert.AreEqual(4, heap.RemoveFirst());
            heap.Add(1);
            Assert.AreEqual(1, heap.RemoveFirst());
            Assert.AreEqual(3, heap.Length);
        }

        [Test]
        public void min_heap_can_make_an_max_heap_from_itself()
        {
            var heap = new Heap<int>(HeapType.Min);
            heap.Add(5);
            heap.Add(100);
            heap.Add(19);
            heap.Add(3);
            heap.Add(7);
            heap.Add(2);

            var maxHeap = heap.Invert();
            Assert.AreEqual(100, maxHeap.RemoveFirst());
            Assert.AreEqual(19, maxHeap.RemoveFirst());
            Assert.AreEqual(7, maxHeap.RemoveFirst());
            Assert.AreEqual(5, maxHeap.RemoveFirst());
            Assert.AreEqual(3, maxHeap.RemoveFirst());
            Assert.AreEqual(2, maxHeap.RemoveFirst());
            Assert.AreEqual(0, maxHeap.Length);
        }

        [Test]
        public void max_heap_can_make_an_min_heap_from_itself()
        {
            var heap = new Heap<int>(HeapType.Max);
            heap.Add(5);
            heap.Add(100);
            heap.Add(19);
            heap.Add(3);
            heap.Add(7);
            heap.Add(2);

            var maxHeap = heap.Invert();
            Assert.AreEqual(2, maxHeap.RemoveFirst());
            Assert.AreEqual(3, maxHeap.RemoveFirst());
            Assert.AreEqual(5, maxHeap.RemoveFirst());
            Assert.AreEqual(7, maxHeap.RemoveFirst());
            Assert.AreEqual(19, maxHeap.RemoveFirst());
            Assert.AreEqual(100, maxHeap.RemoveFirst());
        }

        [Test]
        public void resize_works()
        {
            var heap = new Heap<int>(2);
            heap.Add(1);
            heap.Add(2);
            //rezise
            heap.Add(3);
            heap.Add(4);
            //resize
            heap.Add(5);
            heap.Add(6);
            heap.Add(7);
            heap.Add(8);
            //rezise
            heap.Add(9);
            heap.Add(10);

            Assert.AreEqual(10, heap.Length);
        }
    }
}
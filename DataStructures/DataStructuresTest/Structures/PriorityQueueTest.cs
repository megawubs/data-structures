using DataStructures.Structures;
using DataStructures.Structures.Graph;
using NUnit.Framework;

namespace DataStructuresTest.Structures
{
    [TestFixture]
    public class PriorityQueueTest
    {
        [Test]
        public void it_queues_elements()
        {
            var queue = new PriorityQueue<Node>(HeapType.Min);

            var a = new Node("A") {Dist = 0};
            var b = new Node("B") {Dist = 2};
            var c = new Node("C") {Dist = 1};
            var d = new Node("D") {Dist = 0};

            queue.Enqueue(a);
            queue.Enqueue(b);
            queue.Enqueue(c);
            queue.Enqueue(d);

            Assert.AreEqual(a, queue.Dequeue());
            Assert.AreEqual(d, queue.Dequeue());
            Assert.AreEqual(c, queue.Dequeue());
            Assert.AreEqual(b, queue.Dequeue());
        }

        [Test]
        public void is_empty_works()
        {
            var queue = new PriorityQueue<Node>(HeapType.Min);

            var a = new Node("A") {Dist = 0};
            var b = new Node("B") {Dist = 2};
            var c = new Node("C") {Dist = 1};
            Assert.True(queue.IsEmpty());
            queue.Enqueue(a);
            queue.Enqueue(b);
            queue.Enqueue(c);

            queue.Dequeue();
            queue.Dequeue();

            Assert.False(queue.IsEmpty());
            queue.Dequeue();
            Assert.True(queue.IsEmpty());
        }
    }
}
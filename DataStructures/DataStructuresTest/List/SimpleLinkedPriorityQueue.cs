using NUnit.Framework;

namespace DataStructuresTest.List
{
    [TestFixture]
    public class SimpleLinkedPriorityQueue
    {
        [Test]
        public void we_can_add_ints_to_the_queue()
        {
            var queue = new DataStructures.List.SimpleLinkedPriorityQueue();
            queue.Insert(5);
            queue.Insert(4);
            queue.Insert(3);
            queue.Insert(2);
            queue.Insert(1);
        }

        [Test]
        public void we_can_find_the_smallest_priority()
        {
            var queue = new DataStructures.List.SimpleLinkedPriorityQueue();
            queue.Insert(5);
            queue.Insert(4);
            queue.Insert(3);
            queue.Insert(2);
            queue.Insert(1);

            Assert.AreEqual(1, queue.FindMin());
        }

        [Test]
        public void we_can_remove_the_smallest_priority()
        {
            var queue = new DataStructures.List.SimpleLinkedPriorityQueue();
            queue.Insert(5);
            queue.Insert(4);
            queue.Insert(3);
            queue.Insert(2);
            queue.Insert(1);

            queue.DeleteMin();
            Assert.AreEqual(2, queue.FindMin());

        }

        [Test]
        public void we_can_remove_the_smallest_priority_multiple_times()
        {
            var queue = new DataStructures.List.SimpleLinkedPriorityQueue();
            queue.Insert(5);
            queue.Insert(4);
            queue.Insert(3);
            queue.Insert(2);
            queue.Insert(1);

            queue.DeleteMin();
            Assert.AreEqual(2, queue.FindMin());
            queue.DeleteMin();
            Assert.AreEqual(3, queue.FindMin());
            queue.DeleteMin();
            Assert.AreEqual(4, queue.FindMin());
        }
    }
}
using DataStructures.List;
using DataStructures.Structures.Queue;
using NUnit.Framework;

namespace DataStructuresTest.List
{
    [TestFixture]
    public class SimplyLinkedListQueue
    {
        [Test]
        public void queue_can_be_filled()
        {
            var queue = new SimplyLinkedListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");

            Assert.AreEqual("{*Bram* Maninne Jonah Levi _Piet_ }", queue.ToString());
        }

        [Test]
        public void items_can_be_removed_from_queue()
        {
            var queue = new SimplyLinkedListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");

            queue.Dequeue();

            Assert.AreEqual("{*Maninne* Jonah Levi _Piet_ }", queue.ToString());
        }

        [Test]
        public void list_grows_with_content()
        {
            var queue = new SimplyLinkedListQueue<string>();

            queue.Enqueue("Bram");
            Assert.AreEqual("{_*Bram*_ }", queue.ToString());

            queue.Enqueue("Maninne");
            Assert.AreEqual("{*Bram* _Maninne_ }", queue.ToString());

            queue.Enqueue("Jonah");
            Assert.AreEqual("{*Bram* Maninne _Jonah_ }", queue.ToString());

            queue.Enqueue("Henk");
            Assert.AreEqual("{*Bram* Maninne Jonah _Henk_ }", queue.ToString());

            queue.Enqueue("Willem");
            Assert.AreEqual("{*Bram* Maninne Jonah Henk _Willem_ }", queue.ToString());
        }

        [Test]
        public void dequeueing_a_whole_queue_should_give_an_empty_queue()
        {
            var queue = new SimplyLinkedListQueue<string>();
            queue.Enqueue("Bram");

            queue.Dequeue();

            Assert.AreEqual("{}", queue.ToString());
        }

        [Test]
        public void calling_dequeue_returns_the_expected_item()
        {
            var queue = new SimplyLinkedListQueue<string>();
            queue.Enqueue("Bram");
            queue.Enqueue("Henk");

            Assert.AreEqual("Bram", queue.Dequeue());
            Assert.AreEqual("Henk", queue.Dequeue());
        }

        [Test]
        public void items_can_be_queued_and_dequeued_at_random()
        {
            var queue = new SimplyLinkedListQueue<string>();

            queue.Enqueue("Bram"); //0
            Assert.AreEqual("Bram", queue.Dequeue());
            queue.Enqueue("Maninne"); //0
            queue.Enqueue("Jonah");//1
            queue.Enqueue("Levi");//2
            Assert.AreEqual("Maninne", queue.Dequeue());
            queue.Enqueue("Piet");//3
            queue.Enqueue("Rick");//4
            queue.Enqueue("Suzan");
            Assert.AreEqual("Jonah", queue.Dequeue());
            Assert.AreEqual("{*Levi* Piet Rick _Suzan_ }", queue.ToString());
        }
    }
}
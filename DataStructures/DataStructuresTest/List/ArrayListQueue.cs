using System;
using DataStructures.List;
using DataStructures.Structures.Queue;
using NUnit.Framework;

namespace DataStructuresTest.List
{
    [TestFixture]
    public class ArrayListQueue
    {
        [Test]
        public void queue_can_be_filled()
        {
            var queue = new ArrayListQueue<string>();

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
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");

            queue.Dequeue();

            Assert.AreEqual("{x *Maninne* Jonah Levi _Piet_ }", queue.ToString());
        }

        [Test]
        public void adding_more_items_than_inital_length_makes_queue_two_times_lager()
        {
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");
            queue.Enqueue("Klaas");

            Assert.AreEqual("{*Bram* Maninne Jonah Levi Piet _Klaas_ x x x x x x x x x }", queue.ToString());
        }

        [Test]
        public void the_underlying_array_list_should_not_grow_when_there_is_space_at_the_front()
        {
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");
            queue.Dequeue();
            queue.Enqueue("Klaas");

            Assert.AreEqual("{_Klaas_ *Maninne* Jonah Levi Piet }", queue.ToString());
        }

        [Test]
        public void dequeueing_a_whole_queue_should_give_an_empty_queue()
        {
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");
            for (var i = 0; i < 5; i++)
            {
                queue.Dequeue();
            }

            Assert.AreEqual("{x x x x x }", queue.ToString());
        }

        [Test]
        public void adding_items_after_a_complete_dequeue_should_only_list_the_new_items()
        {
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");

            Assert.AreEqual("Bram", queue.Dequeue());
            Assert.AreEqual("Maninne", queue.Dequeue());
            Assert.AreEqual("Jonah", queue.Dequeue());
            Assert.AreEqual("Levi", queue.Dequeue());
            Assert.AreEqual("Piet", queue.Dequeue());

            queue.Enqueue("Holden");

            Assert.AreEqual("{_*Holden*_ x x x x }", queue.ToString());
        }

        [Test]
        public void we_can_queue_a_queue_twice()
        {
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");
            for (var i = 0; i < 5; i++)
            {
                queue.Dequeue();
            }
            queue.Enqueue("Holden");
            queue.Enqueue("Naomi");
            queue.Enqueue("Amos");
            queue.Enqueue("Miller");
            queue.Enqueue("Alex");

            Assert.AreEqual("{*Holden* Naomi Amos Miller _Alex_ }", queue.ToString());
        }

        [Test]
        public void we_can_dequeue_a_queue_twice()
        {
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");
            for (var i = 0; i < 5; i++)
            {
                queue.Dequeue();
            }
            queue.Enqueue("Holden");
            queue.Enqueue("Naomi");
            queue.Enqueue("Amos");
            queue.Enqueue("Miller");
            queue.Enqueue("Alex");

            for (var i = 0; i < 5; i++)
            {
                queue.Dequeue();
            }

            Assert.AreEqual("{x x x x x }", queue.ToString());
        }

        [Test]
        public void items_can_be_queued_and_dequeued_at_random()
        {
            var queue = new ArrayListQueue<string>();

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
            Assert.AreEqual("{_Suzan_ x *Levi* Piet Rick }", queue.ToString());
        }

        [Test]
        public void when_the_first_and_only_item_is_dequeued_the_next_enqueued_item_takes_it_place()
        {
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram"); //0
            Assert.AreEqual("Bram", queue.Dequeue());
            queue.Enqueue("Maninne"); //0

            Assert.AreEqual("{_*Maninne*_ x x x x }", queue.ToString());
        }


        [Test]
        public void when_expanding_the_internal_order_must_be_reset_front_becomes_the_first_item_and_back_the_last()
        {
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram"); //0
            queue.Enqueue("Maninne"); //1 0
            queue.Enqueue("Jonah");//2 1
            queue.Enqueue("Levi");//3 2
            Assert.AreEqual("Bram", queue.Dequeue());
            Assert.AreEqual("Maninne", queue.Dequeue());
            Assert.AreEqual("Jonah", queue.Dequeue());
            queue.Enqueue("Piet");//4 3
            queue.Enqueue("Rick");//1 4
            queue.Enqueue("Suzan");//0 5
            queue.Enqueue("Willianne");
            queue.Enqueue("Henky");
            Assert.AreEqual("{*Levi* Piet Rick Suzan Willianne _Henky_ x x x x x x x x x }", queue.ToString());
        }

        [Test]
        public void dequeuing_beond_capacity_throws_exception()
        {
            var queue = new ArrayListQueue<string>();

            queue.Enqueue("Bram");
            queue.Enqueue("Maninne");
            queue.Enqueue("Jonah");
            queue.Enqueue("Levi");
            queue.Enqueue("Piet");

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.Throws<IndexOutOfRangeException>(() => queue.Dequeue());
        }
    }
}
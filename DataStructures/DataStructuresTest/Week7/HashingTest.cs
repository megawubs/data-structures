using System;
using DataStructures.Structures;
using NUnit.Framework;

namespace DataStructuresTest.Week7
{
    [TestFixture]
    public class HashingTest
    {
        [Test]
        public void it_generates_a_has_value_from_an_int()
        {
            var hash = new Hashing(11);

            Assert.AreEqual(0, hash.HashValue(11));
            Assert.AreEqual(3, hash.HashValue(3));
            Assert.AreEqual(5, hash.HashValue(27));
            Assert.AreEqual(8, hash.HashValue(19));


            hash = new Hashing(5);
            Assert.AreEqual(0, hash.HashValue(5));
            Assert.AreEqual(1, hash.HashValue(1));
            Assert.AreEqual(2, hash.HashValue(2));
            Assert.AreEqual(3, hash.HashValue(3));
            Assert.AreEqual(4, hash.HashValue(4));
            Assert.AreEqual(2, hash.HashValue(22));

            hash = new Hashing(7);
            Assert.AreEqual(5, hash.HashValue(5));
            Assert.AreEqual(1, hash.HashValue(43));
            Assert.AreEqual(5, hash.HashValue(320));

            hash = new Hashing(29);
            Assert.AreEqual(11, hash.HashValue(40));
            Assert.AreEqual(28, hash.HashValue(550));
            Assert.AreEqual(21, hash.HashValue(49292));
            Assert.AreEqual(19, hash.HashValue(19));
        }
    }
}
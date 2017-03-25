using System;
using DataStructures.Structures;
using NUnit.Framework;

namespace DataStructuresTest.Week7
{
    [TestFixture]
    public class SeperateChainingHashTableTest
    {
        [Test]
        public void it_should_work()
        {
            var it = new SeperateChainingHashTable();
            it.Add(5);
            it.Add(35);
            it.Add(909);
            it.Add(33);
            it.Add(44);
            it.Add(504);
            it.Add(98);
            it.Add(18);
            it.Remove(98);

            Console.Write(it);
        }
    }
}
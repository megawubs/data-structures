using System.Numerics;
using NUnit.Framework;

namespace DataStructuresTest.Week3
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void paw_3_19_works()
        {
            Assert.AreEqual(new BigInteger(1162261467) , DataStructures.Week3.Math.Paw(3, 19));
        }

        [Test]
        public void paw_3_20_works()
        {
            Assert.AreEqual(new BigInteger(3486784401) , DataStructures.Week3.Math.Paw(3, 20));
        }

        [Test]
        public void paw_3_16_works()
        {
            Assert.AreEqual(new BigInteger(43046721) , DataStructures.Week3.Math.Paw(3, 16));
        }

        [Test]
        public void paw_4_5_works()
        {
            Assert.AreEqual(new BigInteger(1024) , DataStructures.Week3.Math.Paw(4, 5));
        }

        [Test]
        public void paw_6_15_works()
        {
            Assert.AreEqual(new BigInteger(470184984576) , DataStructures.Week3.Math.Paw(6, 15));
        }

        [Test]
        public void paw_2_15_works()
        {
            Assert.AreEqual(new BigInteger(32768) , DataStructures.Week3.Math.Paw(2, 15));
        }

        [Test]
        public void paw_works()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Assert.AreEqual(new BigInteger(i) , DataStructures.Week3.Math.Paw(i, 1));
            }
            Assert.AreEqual(new BigInteger(6131066257801) , DataStructures.Week3.Math.Paw(19, 10));
            Assert.AreEqual(new BigInteger(61917364224) , DataStructures.Week3.Math.Paw(12, 10));
        }
    }
}
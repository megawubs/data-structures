using NUnit.Framework;

namespace DataStructuresTest.Week3
{
    [TestFixture]
    public class Palidromen
    {
        [Test]
        public void it_works_with_one_letter()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsTrue(p.Check("f"));
        }

        [Test]
        public void it_works_with_two_of_the_same_letters()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsTrue(p.Check("ff"));
        }

        [Test]
        public void it_works_with_two_different_letters()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsFalse(p.Check("fa"));
        }

        [Test]
        public void it_works_with_two_spaces()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsTrue(p.Check("f f"));
        }

        [Test]
        public void it_works_with_a_real_word()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsTrue(p.Check("abba"));
        }

        [Test]
        public void it_works_with_a_scentence()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsTrue(p.Check("was it a car or a cat I saw"));
        }

        [Test]
        public void it_works_with_a_scentence_2()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsFalse(p.Check("This should not be a palidroom"));
        }

        [Test]
        public void it_works_recusive_with_one_letter()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsTrue(p.CheckRecursive("t"));
        }

        [Test]
         public void it_works_recusive_with_two_letter()
         {
             var p = new DataStructures.Week3.Palidromen();
             Assert.IsTrue(p.CheckRecursive("tt"));
         }

        [Test]
        public void it_works_recusive_with_a_word_thats_even()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsTrue(p.CheckRecursive("abba"));
        }

        [Test]
        public void it_works_recursive_on_a_sentence()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsTrue(p.CheckRecursive("was it a car or a cat I saw"));
        }

        [Test]
        public void it_works_recursive_with_a_scentence_2()
        {
            var p = new DataStructures.Week3.Palidromen();
            Assert.IsFalse(p.CheckRecursive("This should not be a palidroom"));
        }
    }
}
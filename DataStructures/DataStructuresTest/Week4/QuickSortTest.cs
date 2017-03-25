using DataStructures.Week4;
using NUnit.Framework;

namespace DataStructuresTest.Week4
{
    [TestFixture]
    public class QuickSortTest
    {
        [Test]
        public void it_can_sort_a_list_of_10_elements()
        {
            var sortable = new[] {10, 8, 7, 1, 9, 2, 3, 5, 4, 6};
            QuickSort.Sort(sortable);
            Assert.AreEqual(new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, sortable);
        }

        [Test]
        public void it_can_sort_a_small_list_of_ints_with_the_first_two_bing_wrong()
        {
            var sortable = new[] {3, 2, 4};
            QuickSort.Sort(sortable);
            Assert.AreEqual(new [] {2, 3, 4}, sortable);
        }

        [Test]
        public void it_can_sort_a_small_list_of_ints_with_the_last_two_bing_wrong()
        {
            var sortable = new[] {3, 4, 2};
            QuickSort.Sort(sortable);
            Assert.AreEqual(new [] {2, 3, 4}, sortable);
        }

        [Test]
        public void it_can_sort_a_small_list_of_ints_with_the_last_two_bing_wrong2()
        {
            var sortable = new[] {2, 4, 3};
            QuickSort.Sort(sortable);
            Assert.AreEqual(new [] {2, 3, 4}, sortable);
        }

        [Test]
        public void it_can_sort_a_list_of_two_ints()
        {
            var sortable = new[] {4, 3};
            QuickSort.Sort(sortable);
            Assert.AreEqual(new [] {3, 4}, sortable);
        }

        [Test]
        public void it_returns_the_same_when_given_one_element()
        {
            var sortable = new[] {3};
            QuickSort.Sort(sortable);
            Assert.AreEqual(new [] {3}, sortable);
        }

        [Test]
        public void it_can_sort_a_really_long_list()
        {
            var list = new int[51];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i;
            }
            var scrambled = new[] {
                50, 40, 30, 20, 10, 0,
                49, 39, 29, 19, 9,
                48, 38, 28, 18, 8,
                47, 37, 27, 17, 7,
                46, 36, 26, 16, 6,
                45, 35, 25, 15, 5,
                44, 34, 24, 14, 4,
                43, 33, 23, 13, 3,
                42, 32, 22, 12, 2,
                41, 31, 21, 11, 1
            };

            QuickSort.Sort(scrambled);
            Assert.AreEqual(list,scrambled);
        }
    }
}
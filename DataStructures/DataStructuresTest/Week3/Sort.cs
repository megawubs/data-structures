using System.Diagnostics;
using DataStructures.Week1;
using NUnit.Framework;

namespace DataStructuresTest.Week3
{
    [TestFixture]
    public class Sort
    {
        [Test]
        public void insertion_sort_works()
        {
            int[] numbers = {14, 1, 10, 3, 19, 22, 5, 0, 4, 8, 2};
            DataStructures.Week3.Sort.InsertionSort(numbers);
            Assert.AreEqual(new [] {0, 1, 2, 3, 4, 5, 8, 10, 14, 19, 22}, numbers);
        }

        [Test]
        public void shell_sort_works()
        {
            int[] numbers = {14, 1, 10, 3, 19, 22, 5, 0, 4, 8, 2};
            DataStructures.Week3.Sort.ShellSort(numbers);
            Assert.AreEqual(new [] {0, 1, 2, 3, 4, 5, 8, 10, 14, 19, 22}, numbers);
        }

        [Test]
        public void merge_sort_works()
        {
            int[] numbers = {14, 1, 10, 3, 19, 22, 5, 0, 4, 8, 2};
            DataStructures.Week3.Sort.MergeSort(numbers);
            Assert.AreEqual(new [] {0, 1, 2, 3, 4, 5, 8, 10, 14, 19, 22}, numbers);
        }

//        [Test]
//        public void merge_sort_with_big_input()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                int[] randomArray = Random.IntArray(500000 * 5, 0, 500000 * 5);
//                DataStructures.Week3.Sort.MergeSort(randomArray);
//            }
//        }
//
//        [Test]
//        public void shell_sort_with_big_input()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                int[] randomArray = Random.IntArray(500000 * 5, 0, 500000 * 5);
//                DataStructures.Week3.Sort.ShellSort(randomArray);
//            }
//        }
//
//        [Test]
//        public void insertion_sort_with_big_input()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                int[] randomArray = Random.IntArray(500000 * 5, 0, 500000 * 5);
//                DataStructures.Week3.Sort.ShellSort(randomArray);
//            }
//        }
    }
}
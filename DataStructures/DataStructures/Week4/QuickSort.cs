using System;

namespace DataStructures.Week4
{
    public class QuickSort
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            Sort(a, 0, a.Length - 1);
        }

        public static void Sort<T>(T[] a, int low, int high) where T : IComparable<T>
        {
            if (low + 11 > high)
            {
                Week3.Sort.InsertionSort(a);
            }
            else
            {
                int middle = (low + high) / 2;
                if (a[middle].CompareTo(a[low]) < 0)
                {
                    SwapReverence(a, low, middle);
                }
                if (a[high].CompareTo(a[low]) < 0)
                {
                    SwapReverence(a, low, high);
                }
                if (a[high].CompareTo(a[middle]) < 0)
                {
                    SwapReverence(a, middle, high);
                }

                SwapReverence(a, middle, high - 1);
                T pivot = a[high - 1];

                int i, j;
                for (i = low, j = high - 1; ;)
                {
                    while (a[++i].CompareTo(pivot) < 0)
                        ;
                    while (pivot.CompareTo(a[--j]) < 0)
                        ;
                    if (i >= j)
                    {
                        break;
                    }
                    SwapReverence(a, i, j);
                }
                SwapReverence(a, i, high - 1);

                Sort(a, low, i -1);
                Sort(a, i + 1, high);
            }
        }

        public static void SwapReverence<T>(T[] a, int low, int middle) where T : IComparable<T>
        {
            var temp = a[middle];
            a[middle] = a[low];
            a[low] = temp;
        }
    }
}
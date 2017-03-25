using System;

namespace DataStructures.Week3
{
    public class Sort
    {
        public static void InsertionSort<T>(T[] a) where T : IComparable<T>
        {
            for (int p = 1; p < a.Length; p++)
            {
                T tmp = a[p];
                int j = p;
                if (tmp != null)
                {
                    for (; j > 0 && tmp.CompareTo(a[j - 1]) < 0; j--)
                    {
                        a[j] = a[j - 1];
                    }
                    a[j] = tmp;
                }
            }
        }

        public static void ShellSort<T>(T[] a) where T : IComparable<T>
        {
            for (int gap = a.Length/2; gap > 0; gap= gap == 2? 1: (int) (gap/2.2))
            {
                for (int i = gap; i < a.Length; i++)
                {
                    T tmp = a[i];
                    int j = i;
                    for (; j >= gap && tmp.CompareTo(a[j - gap]) < 0; j -= gap)
                    {
                        a[j] = a[j - gap];
                    }
                    a[j] = tmp;
                }
            }
        }

        public static void MergeSort<T>(T[] a) where T : IComparable<T>
        {
            T[] tmpArray = new T[a.Length];
            MergeSort(a, tmpArray, 0, a.Length -1);
        }

        private static void MergeSort<T>(T[] a, T[] tmpArray, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                MergeSort(a, tmpArray, left, center);
                MergeSort(a, tmpArray, center +1, right);
                Merge(a, tmpArray, left, center +1, right);
            }
        }

        private static void Merge<T>(T[]a, T[] tmpArray, int leftPos, int rightPos, int rightEnd) where T : IComparable<T>
        {
            int leftEnd = rightPos - 1;
            int tmpPos = leftPos;
            int numElements = rightEnd - leftPos + 1;

            while (leftPos <= leftEnd && rightPos <= rightEnd)
            {
                if (a[leftPos].CompareTo(a[rightPos]) <= 0)
                {
                    tmpArray[tmpPos++] = a[leftPos++];
                }
                else
                {
                    tmpArray[tmpPos++] = a[rightPos++];
                }
            }
            while (leftPos <= leftEnd)
            {
                tmpArray[tmpPos++] = a[leftPos++];
            }
            while (rightPos <= rightEnd)
            {
                tmpArray[tmpPos++] = a[rightPos++];
            }

            for (int i = 0; i < numElements; i++, rightEnd--)
            {
                a[rightEnd] = tmpArray[rightEnd];
            }
        }
    }
}
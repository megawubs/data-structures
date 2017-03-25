using System.Data;
using DataStructures.List;
using DataStructures.Structures.Lists;

namespace DataStructures.Week1
{
    public class MyAlgorithms
    {
        private static int[] _sum;
        private static bool[] _inArray;
        public int CumulativeSum(int[] array, int index)
        {
            var sum = 0;
            for (var i = 0; i <= index; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public int CumulativeSum(LinkedList<int> list, int index)
        {
            var sum = 0;
            var node = list.First();
            var i = -1;
            while (i < index && node != null)
            {
                sum += node.Data;
                node = node.Next;
                i++;
            }
            return sum;
        }

        public void InitCumulativeSomV2(int[] array)
        {
            _sum = new int[array.Length];
            _sum[0] = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                _sum[i] = _sum[i - 1] + array[i];
            }

        }
        public int CumulativeSumV2(int[] array, int index)
        {
            return _sum[index];
        }

        public double[] MovingAverage(int[] input, int n)
        {
            var movingAverage = new double[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                int devider = i < n ? i + 1 : n;
                var min = i < n ? 0 : i - n + 1;
                var sum = 0;
                for (var j = i; j >= min; j--)
                {
                    sum += input[j];
                }
                movingAverage[i] = (double) sum / devider;
            }
            return movingAverage;
        }

        public DoubleLinkedList<double> MovingAverage(DoubleLinkedList<int> input, int n)
        {
            var movingAverage = new DoubleLinkedList<double>();
            var node = input.First();
            var i = 0;
            while (node != null && i < input.Length)
            {
                int devider = i < n ? i + 1 : n;
                var min = i < n ? 0 : i - n + 1;
                var sum = (double)node.Data;
                var previous = node.Previous;
                var j = i;
                while (previous != null && j > min)
                {
                    sum += previous.Data;
                    previous = previous.Previous;
                    j--;
                }
                movingAverage.Add(sum / devider);

                node = node.Next;
                i++;
            }

            return movingAverage;
        }

        public static int[] Merge(int[] array1, int[] array2)
        {
            var merged = new int[array1.Length + array2.Length];
            int indexOnArray1 = 0;
            int indexOnArray2 = 0;
            bool doneWithArray2 = false;
            bool doneWithArray1 = false;
           for (var i = 0; i < merged.Length; i++)
           {
               if (doneWithArray2 == false && doneWithArray1 == false)
               {
                   if (array2[indexOnArray2] < array1[indexOnArray1] ||
                       array2[indexOnArray2] == array1[indexOnArray1])
                   {
                       merged[i] = array2[indexOnArray2];
                       indexOnArray2 = indexOnArray2 < array2.Length ? indexOnArray2 + 1 : indexOnArray2;
                       doneWithArray2 = indexOnArray2 == array2.Length;
                   }
                   else if (array2[indexOnArray2] > array1[indexOnArray1])
                   {
                       merged[i] = array1[indexOnArray1];
                       indexOnArray1 = indexOnArray1 < array1.Length ? indexOnArray1 + 1 : indexOnArray1;
                       doneWithArray1 = indexOnArray1 == array1.Length;
                   }
               }
               else
               {
                   if (doneWithArray2)
                   {
                       merged[i] = array1[indexOnArray1];
                       indexOnArray1++;
                   }
                   if (doneWithArray1)
                   {
                       merged[i] = array2[indexOnArray2];
                       indexOnArray2++;
                   }
               }
           }
            return merged;
        }

        public static int[] MakeHistoGram(int[] input, int[] borders)
        {
            var bins = new int[borders.Length -1];
            foreach (var t in input)
            {
                for (var y = 0; y < borders.Length; y++)
                {
                    if (t >= borders[y] && t < borders[y + 1])
                    {
                        bins[y]++;
                    }
                }
            }
            return bins;
        }


        public static bool InArray(int[] haystack, int needle)
        {
            foreach (var t in haystack)
            {
                if (t == needle)
                {
                    return true;
                }
            }
            return false;
        }

        public void InitInArrayV2(int[] array)
        {
            int lenght = 0;
            foreach (var t in array)
            {
                lenght = t > lenght ? t : lenght;
            }
            _inArray = new bool[lenght + 1];
            foreach (var t in array)
            {
                _inArray[t] = true;
            }

        }

        public bool InArrayV2(int element)
        {
            return element < _inArray.Length && _inArray[element];
        }
    }
}
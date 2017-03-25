using DataStructures.List;
using DataStructures.Structures.Lists;

namespace DataStructures.Week1
{
    public class Runner : IRunner
    {
        public void Run()
        {
            new Complexity().MesureGetMax();
            new Complexity().MesureCumulativeSum();

            new Complexity().MesureCulumativeSumV2();
            new Complexity().MesureMesureCumulativeSumAndMesureCulumativeSumV2();
             new Complexity().MesureMovingAverage();
            var array1 = new []{9, 10, 12, 50};
            var array2 = new[] {1, 10, 11, 13};
            var res1 = MyAlgorithms.Merge(array1, array2);

            var histoGramData = new int[] {9, 8, 4, 3, 8, 1, 1, 2, 8, 2, 1, 6, 0, 9, 8, 7, 0, 7, 3, 2, 11, 3, 4,6,7,7,8,8};
            var borders = new int[] {0, 3, 6, 9, 12};
            var res2 = MyAlgorithms.MakeHistoGram(histoGramData, borders);

            var haystack = new int[] {0, 1, 5};
            bool has3 = MyAlgorithms.InArray(haystack, 10);
            var algoritms = new MyAlgorithms();
            algoritms.InitInArrayV2(haystack);
            bool has4 = algoritms.InArrayV2(5);

            ArrayList<int> list = new ArrayList<int>(10);
            list.Add(1);
            list.Add(2);
            list.Set(9, 2);
            list.Clear();
            list.Print();
        }
    }
}
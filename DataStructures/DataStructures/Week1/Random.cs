namespace DataStructures.Week1
{
    public class Random
    {
        public static int[] IntArray(int length, int min, int max)
        {
            System.Random random = new System.Random();
            var numbers = new int[length];
            for (var i = 0; i < length; i++)
            {
                numbers[i] = random.Next(min, max);
            }

            return numbers;
        }

        public static double[] DoubleArray(int lenght, int min, int max)
        {
            System.Random random = new System.Random();
            var numbers = new double[lenght];
            for (var i = 0; i < lenght; i++)
            {
                numbers[i] = random.NextDouble() * (max - min) + max;
            }
            return numbers;
        }

        public static int GetMaxIndex(double[] array)
        {
            double max = GetMax(array);
            int index = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static double GetMax(double[] array)
        {
            double max = 0.0;
            foreach (var d in array)
            {
                max = d > max ? d : max;
            }
            return max;
        }

    }
}
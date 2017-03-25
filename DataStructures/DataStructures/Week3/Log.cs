namespace DataStructures.Week3
{
    public class Log
    {
        public static int Log2Floor(int x)
        {
            int numberOfTries = 0;
            while (x > 1)
            {
                x = x / 2;
                numberOfTries++;
            }
            return numberOfTries;
        }

        public static int Log2FloorRecursive(int x, int tries = 0)
        {
            if (x <= 1)
            {
                return tries;
            }
            return Log2FloorRecursive(x / 2, tries + 1);
        }

        public static int LogNFloor(int n, int x)
        {
            int numberOfTries = 0;
            while (x > 1)
            {
                x = x / n;
                numberOfTries++;
            }
            return numberOfTries;
        }

        public static int LogNFloorRecursive(int n, int x, int tries = 0)
        {
            if (x <= 1)
            {
                return tries;
            }
            return Log2FloorRecursive(x / n, tries + 1);
        }
    }
}
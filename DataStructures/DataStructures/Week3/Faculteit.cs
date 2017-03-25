namespace DataStructures.Week3
{
    public class Faculteit
    {
        public int NotRecursive(int n)
        {
            int faculteit = 1;
            for (int i = 1; i <= n; i++)
            {
                faculteit *= i;
            }
            return faculteit;
        }

        public int Recursive(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Recursive(n - 1);
        }
    }
}
using System.Numerics;
using System.Threading.Tasks;

namespace DataStructures.Week3
{
    public class Math
    {
        public static BigInteger Paw(int x, int y)
        {
            int paw = 2;
            BigInteger[] paws = new BigInteger[y];
            BigInteger[] pawMap = new BigInteger[y + 1];
            paws[0] = x;
            pawMap[1] = x;
            var i = 1;
            while (paw <= y)
            {
                paws[i] = paws[i - 1] * paws[i - 1];
                pawMap[paw] = paws[i];
                paw = paw * 2;
                i++;
            }
            var remaining = y - paw/2;
            while (remaining > 0)
            {
                if (pawMap[remaining] == 0)
                {
                    paws[i] = paws[i - 1] * pawMap[2];
                    remaining = remaining - 2;
                    i++;
                }
                else
                {
                    paws[i] = paws[i - 1] * pawMap[remaining];
                    remaining = 0;
                    i++;
                }
            }
            return paws[i - 1];
        }
    }
}
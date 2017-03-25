
using System.CodeDom;

namespace DataStructures.Week3
{
    public class Palidromen
    {
        public bool Check(string words)
        {
            words = words.Replace(" ", "").ToLower();
            if (words.Length == 1)
            {
                return true;
            }
            var reverse = "";
            for (int i = words.Length - 1 ; i >= 0; i--)
            {
                reverse += words[i];
            }

            return reverse == words;
        }

        public bool CheckRecursive(string words, int index = 0)
        {
            if (index == 0)
            {
                words = words.Replace(" ", "").ToLower();
            }

            var indexToCheck = words.Length - 1 - index;
            var checkUntill = words.Length / 2;
            
            if (words.Length == 1 || indexToCheck == checkUntill)
            {
                return true;
            }

            if (words[index] == words[indexToCheck])
            {
                return CheckRecursive(words, index+1);
            }

            return false;
        }
    }
}
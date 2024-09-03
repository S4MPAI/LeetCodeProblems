using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1657
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length) 
                return false;
            var lettersCount1 = GetLettersCount(word1);
            var lettersCount2 = GetLettersCount(word2);
            var chars1 = lettersCount1.Select((x, i) => x > 0 ? i : -1).Where(x => x > -1).ToArray();
            var chars2 = lettersCount2.Select((x, i) => x > 0 ? i : -1).Where(x => x > -1).ToArray();
            if (chars1.Length != chars2.Length) 
                return false;

            var length = chars1.Length;
            for (int i = 0; i < length; i++)
                if (chars1[i] != chars2[i])
                    return false;

            var charsCount1 = lettersCount1.Where(x => x > 0).OrderBy(x => x).ToArray();
            var charsCount2 = lettersCount2.Where(x => x > 0).OrderBy(x => x).ToArray();

            for (int i = 0; i < length; i++)
                if (charsCount1[i] != charsCount2[i])
                    return false;

            return true;
        }

        public int[] GetLettersCount(string word)
        {
            var res = new int[26];

            foreach (var c in word)
                res[c - 'a'] += 1;

            return res;
        }
    }
}

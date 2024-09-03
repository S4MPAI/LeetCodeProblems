using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1456
    {
        public int MaxVowels(string s, int k)
        {
            var vowelCount = 0;
            for (int i = 0; i < k; i++)
                vowelCount += IsVowel(s[i]) ? 1 : 0;
            var maxVowelCount = vowelCount;

            for (int i = k;i < s.Length; i++)
            {
                vowelCount += IsVowel(s[i]) ? 1 : 0;
                vowelCount += IsVowel(s[i - k]) ? -1 : 0;
                maxVowelCount = Math.Max(vowelCount, maxVowelCount);
            }

            return maxVowelCount;
        }

        public bool IsVowel(char c) => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}

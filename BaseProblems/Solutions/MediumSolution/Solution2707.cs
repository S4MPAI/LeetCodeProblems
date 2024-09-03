using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2707
    {
        private HashSet<string> dictionarySet;

        private int?[] memory;

        public int MinExtraChar(string s, string[] dictionary)
        {
            var n = s.Length;
            dictionarySet = new HashSet<string>(dictionary);
            memory = new int?[n];
            return GetMinExtraChar(0, n, s);
        }

        private int GetMinExtraChar(int start, int length, string word)
        {
            if (start == length)
                return 0;
            if (memory[start] != null)
                return memory[start].Value;

            var ans = GetMinExtraChar(start + 1, length, word) + 1;
            for (int end = start; end < length; end++)
            {
                var current = word[start..(end + 1)];
                if (dictionarySet.Contains(current))
                    ans = Math.Min(ans, GetMinExtraChar(end + 1, length, current));
            }

            return (memory[start] = ans).Value;
        }
    }
}

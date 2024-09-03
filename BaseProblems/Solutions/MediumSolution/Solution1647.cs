using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1647
    {
        public int MinDeletions(string s)
        {
            var charsCount = new Dictionary<char, int>();
            var uniqueCount = new HashSet<int>();
            var deleteCount = 0;

            foreach (char c in s)
            {
                if (!charsCount.ContainsKey(c))
                    charsCount[c] = 0;
                charsCount[c]++;
            }

            foreach (var count in charsCount.Values)
            {
                var val = count;
                while (uniqueCount.Contains(val) && val != 0)
                {
                    val--;
                    deleteCount++;
                }

                uniqueCount.Add(val);
            }

            return deleteCount;
        }
    }
}

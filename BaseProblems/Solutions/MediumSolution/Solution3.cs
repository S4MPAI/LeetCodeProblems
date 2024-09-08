using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution3
    {
        public int LengthOfLongestSubstring(string s)
        {
            var substringData = new HashSet<char>();
            var startIndex = 0;
            var maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (substringData.Contains(s[i]))
                {
                    maxLength = Math.Max(maxLength, i - startIndex);
                    while (s[startIndex] != s[i])
                    {
                        substringData.Remove(s[startIndex]);
                        startIndex++;
                    }

                    startIndex++;
                }

                substringData.Add(s[i]);
            }

            return Math.Max(maxLength, s.Length - startIndex);
        }
    }
}

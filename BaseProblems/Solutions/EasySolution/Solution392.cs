using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution392
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;
            if (t.Length == 0) return false;

            var currentIndex = 0;

            for (var i = 0; i < t.Length; i++)
            {
                if (s[currentIndex] == t[i])
                    currentIndex++;

                if (currentIndex >= s.Length)
                    return true;
            }

            return false;
        }
    }
}

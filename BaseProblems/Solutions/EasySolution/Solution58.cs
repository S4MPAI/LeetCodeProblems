using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution58
    {
        public int LengthOfLastWord(string s)
        {
            var count = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                    count++;

                if (s[i] == ' ' && count > 0)
                    break;
            }

            return count;
        }
    }
}

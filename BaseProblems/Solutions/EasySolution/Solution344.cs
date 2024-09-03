using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution344
    {
        public void ReverseString(char[] s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                (s[left], s[right]) = (s[right], s[left]);
                left++;
                right--;
            }
        }
    }
}

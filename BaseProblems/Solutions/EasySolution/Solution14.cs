using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var prefix = strs[0];

            foreach (var str in strs)
                for (var i = 0; i < prefix.Length; i++)
                    if (i >= str.Length || str[i] != prefix[i])
                        prefix = prefix.Substring(0, i);

            return prefix;
        }
    }
}

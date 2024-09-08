using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution28
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length > haystack.Length)
                return -1;

            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                var isSuccess = true;

                for(int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        isSuccess = false;
                        break;
                    }
                }

                if (isSuccess)
                    return i;
            }

            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1143
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            var dpData = new int[2][];
            for (int i = 0; i < 2; i++)
                dpData[i] = new int[text2.Length + 1];

            for (int i = 1; i <= text1.Length; i++)
            {
                for (int j = 1; j <= text2.Length; j++)
                {
                    dpData[1][j] = Math.Max(dpData[0][j], dpData[1][j - 1]);

                    if (text1[i - 1] == text2[j - 1])
                    {
                        dpData[1][j] = Math.Max(dpData[1][j], dpData[0][j - 1] + 1);
                    }
                }

                (dpData[0], dpData[1]) = (dpData[1], dpData[0]);
            }

            return dpData[0][^1];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution377
    {
        public int CombinationSum4(int[] nums, int target)
        {
            var table = new int[target + 1];
            table[0] = 1;

            for (int i = 1; i < table.Length; i++)
                foreach (int x in nums)
                    if (i - x > 0)
                        table[i] += table[i - x];

            return table[^1];
        }
    }
}

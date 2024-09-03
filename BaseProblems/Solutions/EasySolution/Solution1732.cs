using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution1732
    {
        public int LargestAltitude(int[] gain)
        {
            var maxSum = 0;
            var currentSum = 0;

            foreach (var altitude in gain)
            {
                currentSum += altitude;
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}

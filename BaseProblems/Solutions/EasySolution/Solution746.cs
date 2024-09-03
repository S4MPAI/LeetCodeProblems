using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution746
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var minCosts = new int[cost.Length + 1];
            Array.Fill(minCosts, int.MaxValue);
            minCosts[0] = 0;
            minCosts[1] = 0;

            for (var i = 0; i < cost.Length; i++)
            {
                var minCost = minCosts[i] + cost[i];
                if (minCosts[i + 1] > minCost)
                {
                    minCosts[i + 1] = minCost;
                }

                if (i + 2 < minCosts.Length && minCosts[i + 2] > minCost)
                {
                    minCosts[i + 2] = minCost;
                }
            }

            return minCosts[^1];
        }
    }
}

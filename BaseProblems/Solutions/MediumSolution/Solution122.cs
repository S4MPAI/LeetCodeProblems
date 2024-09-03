using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution122
    {
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
                if (prices[i] > prices[i - 1])
                    maxProfit += prices[i] - prices[i - 1];

            return maxProfit;
        }
    }
}

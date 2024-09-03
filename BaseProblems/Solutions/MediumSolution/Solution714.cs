using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution714
    {
        public int MaxProfit(int[] prices, int fee)
        {
            if (prices.Length <= 1)
                return 0;

            int saving = -prices[0];
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                profit = Math.Max(profit, saving + prices[i] - fee);
                saving = Math.Max(saving, profit - prices[i]);
            }

            return profit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution787
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            var prices = new int[n];
            Array.Fill(prices, int.MaxValue);
            prices[src] = 0;

            for (int i = 0; i <= k; i++)
            {
                var temp = (int[])prices.Clone();

                foreach (var flight in flights)
                {
                    if (prices[flight[0]] != int.MaxValue)
                        temp[flight[1]] = Math.Min(prices[flight[0]] + flight[2], temp[flight[1]]);
                }
                prices = temp;
            }

            return prices[dst] != int.MaxValue ? prices[dst] : -1;
        }
    }
}

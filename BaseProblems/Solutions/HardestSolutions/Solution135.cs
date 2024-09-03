using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.HardestSolutions
{
    public class Solution135
    {
        public int Candy(int[] ratings)
        {
            var candiesData = Enumerable.Repeat(1, ratings.Length).ToArray();

            for (int i = 1; i < candiesData.Length; i++)
                if (ratings[i] > ratings[i - 1])
                    candiesData[i] = candiesData[i - 1] + 1;

            for (int i = candiesData.Length - 1; i > -1; i--)
            {
                if (ratings[i] > ratings[i + 1])
                    candiesData[i] = Math.Max(candiesData[i], candiesData[i + 1] + 1);
            }

            return candiesData.Sum();
        }
    }
}

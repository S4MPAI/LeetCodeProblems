using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var kidsWithGreatestNumber = new bool[candies.Length];
            var max = candies.Max();

            for (int i = 0; i < candies.Length; i++)
                kidsWithGreatestNumber[i] = candies[i] + extraCandies > max;

            return kidsWithGreatestNumber;
        }
    }
}

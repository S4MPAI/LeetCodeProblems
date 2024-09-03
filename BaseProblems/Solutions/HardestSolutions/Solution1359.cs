using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.HardestSolutions
{
    public class Solution1359
    {
        public int CountOrders(int n)
        {
            var modulo = (int)Math.Pow(10, 9) + 7;
            var combinationsCountData = new long[n];
            combinationsCountData[0] = 1;
            var orderCombinations = new int[n];

            var number = n * 2;
            var combinations = 0;
            for (int i = 1; i < number; i++)
            {
                combinations += i;
                if (i % 2 == 1)
                    orderCombinations[i / 2] = combinations;
            }

            for (int i = 1; i < n; i++)
                combinationsCountData[i] = (combinationsCountData[i - 1] * orderCombinations[i]) % modulo;

            return (int)combinationsCountData[^1];
        }
    }
}

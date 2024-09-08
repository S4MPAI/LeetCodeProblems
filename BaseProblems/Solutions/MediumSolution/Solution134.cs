using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution134
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var sumGas = 0;
            var sumCost = 0;

            for (var i = 0; i < gas.Length; i++)
            {
                sumGas += gas[i];
                sumCost += cost[i];
            }

            if (sumCost > sumGas)
                return -1;

            var current = 0;
            var startPos = 0;

            for (var i = 0; i < gas.Length; i++)
            {
                current += gas[i] - cost[i];

                if (current < 0)
                {
                    startPos = i + 1;
                    current = 0;
                }
            }

            return startPos;
        }
    }
}

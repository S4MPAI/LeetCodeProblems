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
            var gasTank = gas[0];
            var startGasCost = cost[0];
            var startStation = 0;

            for (int i = 1; i < gas.Length; i++)
            {
                gasTank += gas[i];

                if (gasTank - startGasCost > gasTank - cost[i])
                {
                    startStation = i;
                    gasTank -= startGasCost;
                    startGasCost = cost[i];
                }
                else
                    gasTank -= cost[i];
            }

            return gasTank - startGasCost >= 0 ? startStation : -1;
        }
    }
}

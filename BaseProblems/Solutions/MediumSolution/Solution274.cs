using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution274
    {
        public int HIndex(int[] citations)
        {
            var counts = new int[citations.Max() + 1];
            
            var hIndex = 0;

            foreach (var c in citations)
                counts[c]++;

            for (var i = counts.Length - 1; i >= 0; i--)
            {
                hIndex += counts[i];

                if (i <= hIndex)
                {
                    hIndex = i;
                    break;
                }
            }

            return hIndex;
        }
    }
}

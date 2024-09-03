using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution875
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            var left = 1;
            var right = piles.Max();

            while (left < right)
            {
                var middle = left + (right - left) / 2;

                if (IsEnough(piles, middle, h))
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return left;
        }

        private bool IsEnough(int[] piles, int eating, int h)
        {
            var hours = 0;

            foreach (var p in piles)
            {
                hours += (p + eating - 1) / eating;
            }

            return hours <= h;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1318
    {
        public int MinFlips(int a, int b, int c)
        {
            var flips = 0;

            for (int i = 0; i < 32; i++)
            {
                var mask = (1 << i);
                var aBit = a & mask;
                var bBit = b & mask;
                var cBit = c & mask;

                if (cBit == 0)
                {
                    if (aBit > 0 && bBit > 0)
                        flips += 2;
                    else if (aBit > 0 || bBit > 0)
                        flips++;
                }
                else
                {
                    if (aBit == 0 && bBit == 0)
                        flips++;
                }
            }

            return flips;
        }
    }
}

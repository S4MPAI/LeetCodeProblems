using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution343
    {
        public int IntegerBreak(int n)
        {
            if (n <= 3)
            {
                return n - 1;
            }

            if (n == 4) return 4;

            var product = 1;

            while (n != 0)
            {
                if (n >= 5 || n == 3)
                {
                    product *= 3;
                    n -= 3;
                }
                else
                {
                    product *= 2;
                    n -= 2;
                }
            }

            return product;
        }
    }
}

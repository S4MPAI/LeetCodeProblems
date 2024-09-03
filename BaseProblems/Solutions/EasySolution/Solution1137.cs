using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution1137
    {
        public int Tribonacci(int n)
        {
            if (n < 3)
            {
                return n > 0 ? 1 : 0;
            }

            var tribonacciArray = new int[n + 1];
            tribonacciArray[1] = 1;
            tribonacciArray[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                tribonacciArray[i] = tribonacciArray[i - 3] + tribonacciArray[i - 2] + tribonacciArray[i - 1];
            }

            return tribonacciArray[^1];
        }
    }
}

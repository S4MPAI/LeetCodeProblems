using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    internal class Solution1512
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var numbersIndexes = new Dictionary<int, int>();
            var result = 0;

            foreach ( var i in nums )
            {
                if (!numbersIndexes.ContainsKey(i)) 
                {
                    numbersIndexes[i] = 1;
                }
                else
                {
                    result += numbersIndexes[i];
                    numbersIndexes[i]++;
                }
            }
            
            return result;
        }
    }
}

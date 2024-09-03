using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution136
    {
        public int SingleNumber(int[] nums)
        {
            var xor = 0;

            foreach (var x in nums)
            {
                xor ^= x;
            }

            return xor;
        }
    }
}

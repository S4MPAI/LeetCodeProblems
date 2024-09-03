using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int result = 0;
            foreach (var item in nums)
            {
                if (item != val)
                {
                    nums[result] = item;
                    result++;
                }
            }

            return result;
        }
    }
}

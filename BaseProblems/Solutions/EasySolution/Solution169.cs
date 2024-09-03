using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution169
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int element = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    element = num;
                }
                if (element == num)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return element;
        }
    }
}

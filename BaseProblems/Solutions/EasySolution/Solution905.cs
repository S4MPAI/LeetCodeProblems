using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution905
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var evenPointer = 1;
            var oddPointer = 0;

            while (evenPointer < nums.Length && oddPointer < nums.Length)
            {
                while (evenPointer < nums.Length && nums[evenPointer] % 2 != 0)
                    evenPointer++;

                while (oddPointer < nums.Length && nums[oddPointer] % 2 != 1)
                    oddPointer++;

                if (oddPointer < evenPointer && evenPointer < nums.Length && oddPointer < nums.Length)
                {
                    (nums[evenPointer], nums[oddPointer]) = (nums[oddPointer], nums[evenPointer]);
                    oddPointer++;
                    evenPointer++;
                }
                else
                {
                    evenPointer++;
                }
            }

            return nums;
        }
    }
}

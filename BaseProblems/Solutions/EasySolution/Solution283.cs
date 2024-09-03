using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution283
    {
        public void MoveZeroes(int[] nums)
        {
            var zeroPointer = 0;
            var pointer = 1;

            while (pointer < nums.Length)
            {
                while (zeroPointer < nums.Length && nums[zeroPointer] != 0)
                    zeroPointer++;

                while (pointer < nums.Length && (nums[pointer] == 0 || zeroPointer > pointer))
                    pointer++;

                if (zeroPointer < nums.Length && pointer < nums.Length)
                {
                    (nums[pointer], nums[zeroPointer]) = (nums[zeroPointer], nums[pointer]);
                    pointer++;
                    zeroPointer++;
                }
            }
        }
    }
}

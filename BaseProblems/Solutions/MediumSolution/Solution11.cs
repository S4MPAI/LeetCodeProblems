using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution11
    {
        public int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var maxArea = 0;
            
            while (left < right)
            {
                var currentArea = (right - left) * Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, currentArea);

                if (height[left] > height[right])
                    right--;
                else
                    left++;
            }

            return maxArea;
        }
    }
}

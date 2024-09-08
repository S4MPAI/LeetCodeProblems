using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var leftNumberIndex = 0;
            var rightNumberIndex = numbers.Length - 1;
            var sum = numbers[leftNumberIndex] + numbers[rightNumberIndex];

            while (sum != target)
            {
                if (sum > target)
                    rightNumberIndex = BinarySearch(numbers, target - numbers[leftNumberIndex], leftNumberIndex + 1, rightNumberIndex - 1);
                else
                    leftNumberIndex = BinarySearch(numbers, target - numbers[rightNumberIndex], leftNumberIndex + 1, rightNumberIndex - 1);

                sum = numbers[leftNumberIndex] + numbers[rightNumberIndex];
            }

            return new int[] { leftNumberIndex + 1, rightNumberIndex + 1 };
        }

        private static int BinarySearch(int[] numbers, int target, int left, int right)
        {
            while (left < right)
            {
                var current = left + (right - left) / 2;

                if (numbers[current] > target)
                    right = current - 1;
                else if (numbers[current] < target)
                    left = current + 1;
                else
                    return current;
            }

            return left;
        }
    }
}

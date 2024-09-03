using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution216
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<IList<int>> results = new();
            Stack<int> stack = new();
            FindSum(1, k, n);
            return results;

            void FindSum(int startingValue, int numberOfNumbers, int targetSum)
            {
                if (targetSum is 0 && numberOfNumbers is 0) results.Add(stack.ToArray());
                if (targetSum is 0 || numberOfNumbers is 0) return;

                for (int value = startingValue; value < 10; value++)
                {
                    stack.Push(value);
                    FindSum(value + 1, numberOfNumbers - 1, targetSum - value);
                    stack.Pop();
                }
            }
        }
    }
}

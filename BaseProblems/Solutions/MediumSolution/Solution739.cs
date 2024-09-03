using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution739
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var stack = new Stack<(int temp, int index)>();
            var result = new int[temperatures.Length];

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count > 0 && temperatures[i] > stack.Peek().temp)
                {
                    var index = stack.Pop().index;
                    result[index] = i - index;
                }

                stack.Push((temperatures[i], i));
            }

            return result;
        }
    }
}

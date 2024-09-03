using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution547
    {
        public int FindCircleNum(int[][] isConnected)
        {
            var isVisited = new bool[isConnected.Length];
            var stack = new Stack<int>();
            var provinceCount = 0;

            while (isVisited.Any(x => !x))
            {
                var connection = Array.FindIndex(isVisited, x => !x);
                stack.Push(connection);
                isVisited[connection] = true;

                while (stack.Count > 0)
                {
                    var num = stack.Pop();

                    for (int i = 0; i < isConnected.Length; i++)
                    {
                        if (!isVisited[i] && isConnected[num][i] == 1)
                        {
                            stack.Push(i);
                            isVisited[i] = true;
                        }
                    }
                }

                provinceCount++;
            }

            return provinceCount;
        }
    }
}

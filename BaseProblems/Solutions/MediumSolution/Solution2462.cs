using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2462
    {
        public long TotalCost(int[] costs, int k, int candidates)
        {
            var priorityCandidates = new PriorityQueue<(int num,int index), (int num, int index)>();
            var leftIndex = candidates - 1;
            var rightIndex = Math.Max(costs.Length - candidates, candidates);
            var totalCost = 0L;

            for (int i = costs.Length - 1; i >= rightIndex; i--)
            {
                priorityCandidates.Enqueue((costs[i], i), (costs[i], i));
            }

            for (int i = 0; i <= leftIndex; i++)
            {
                priorityCandidates.Enqueue((costs[i], i), (costs[i], i));
            }

            for (int i = 0; i < k; i++)
            {
                var data = priorityCandidates.Dequeue();
                totalCost += data.num;

                if (leftIndex + 1 == rightIndex)
                    continue;

                if (data.index <= leftIndex)
                {
                    priorityCandidates.Enqueue((costs[++leftIndex], leftIndex), (costs[leftIndex], leftIndex));
                }
                else
                {
                    priorityCandidates.Enqueue((costs[--rightIndex], rightIndex), (costs[rightIndex], rightIndex));
                }
            }

            return totalCost;
        }
    }
}

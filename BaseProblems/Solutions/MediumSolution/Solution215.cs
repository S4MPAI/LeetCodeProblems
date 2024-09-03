using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution215
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var priorityQueue = new PriorityQueue<int, int>();

            foreach (int i in nums)
            {
                if (priorityQueue.Count < k)
                {
                    priorityQueue.Enqueue(i, i);
                    continue;
                }

                var num = priorityQueue.Peek();

                if (i >  num)
                {
                    priorityQueue.EnqueueDequeue(i, i);
                }
            }

            return priorityQueue.Peek();
        }
    }
}

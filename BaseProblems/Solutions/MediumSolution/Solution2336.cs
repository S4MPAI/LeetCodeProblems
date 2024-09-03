using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution2336
    {
        public class SmallestInfiniteSet
        {
            PriorityQueue<int, int> queue;

            public SmallestInfiniteSet()
            {
                queue = new PriorityQueue<int, int>(Enumerable.Range(1, 1000).Select(x => (x, x)));
            }

            public int PopSmallest()
            {
                var num = queue.Dequeue();

                while (queue.Count > 0 && queue.Peek() == num) 
                {
                    queue.Dequeue();
                }

                return num;
            }

            public void AddBack(int num)
            {
                queue.Enqueue(num, num);
            }
        }
    }
}

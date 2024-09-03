using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution933
    {
        private Queue<int> lastRequest;

        public void RecentCounter()
        {
            lastRequest = new Queue<int>();
        }

        public int Ping(int t)
        {
            while (lastRequest.Count > 0 && lastRequest.Peek() < t - 3000)
                lastRequest.Dequeue();

            lastRequest.Enqueue(t);
            return lastRequest.Count;
        }
    }
}

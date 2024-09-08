using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.HardestSolutions
{
    public class Solution42
    {
        public int Trap(int[] height)
        {
            var queue = new PriorityQueue<int, int>();
            var result = 0;
            var lastMaxPoint = 0;

            for (var i = 0; i < height.Length; i++)
            {
                if (height[i] < lastMaxPoint)
                    lastMaxPoint = 0;

                while (queue.TryPeek(out var index, out var indexHeight) && height[i] > 0)
                {
                    if (height[i] >= indexHeight)
                        result += GetTrapWater(queue.Dequeue(), i, height[i], lastMaxPoint, indexHeight);
                    else
                    {
                        result += GetTrapWater(index, i, height[i], lastMaxPoint, indexHeight);
                        break;
                    }

                    lastMaxPoint = Math.Min(height[i], indexHeight);
                }

                if (height[i] > 0)
                    queue.Enqueue(i, height[i]);
            }

            return result;
        }

        private static int GetTrapWater( int previousPoint, int currentPoint, int currentHeight, int lastMaxHeight, int indexHeight)
        {
            return (currentPoint - previousPoint - 1) * (Math.Min(currentHeight, indexHeight) - lastMaxHeight);
        }
    }
}

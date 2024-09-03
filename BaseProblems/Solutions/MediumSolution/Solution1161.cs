using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1161
    {
        public int MaxLevelSum(TreeNode root)
        {
            var maxSum = int.MinValue;
            var maxLevel = 0;
            var currentLevel = 0;

            var queueNodes = new Queue<TreeNode>();
            queueNodes.Enqueue(root);

            while (queueNodes.Any())
            {
                var c = queueNodes.Count();
                var currentSum = 0;
                currentLevel++;

                for (int i = 0; i < c; i++)
                {
                    var node = queueNodes.Dequeue();

                    if (node.left != null)
                        queueNodes.Enqueue(node.left);

                    if (node.right != null)
                        queueNodes.Enqueue(node.right);

                    currentSum += node.val;
                }

                if (currentSum > maxSum)
                    (maxSum, maxLevel) = (currentSum, currentLevel);
            }

            return maxLevel;
        }
    }
}

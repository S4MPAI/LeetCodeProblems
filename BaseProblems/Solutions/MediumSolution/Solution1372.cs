using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1372
    {
        public int LongestZigZag(TreeNode root)
        {
            if (root.left == null && root.right == null) 
                return 0;

            var left = GetMaxZigZag(root, true, 0);
            var right = GetMaxZigZag(root, false, 0);

            return Math.Max(left, right) - 1;
        }

        private int GetMaxZigZag(TreeNode node, bool isLeft, int currentLength) 
        {
            if (node == null) return currentLength;
            var current = isLeft ? GetMaxZigZag(node.right, false, currentLength + 1) : GetMaxZigZag(node.left, true, currentLength + 1);
            var alternative = isLeft ? GetMaxZigZag(node.left, isLeft, 1) : GetMaxZigZag(node.right, isLeft, 1);

            return Math.Max(current, alternative);
        }
    }
}

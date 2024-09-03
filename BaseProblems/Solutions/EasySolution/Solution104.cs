using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            return GetMaxDepth(root, 1);
        }

        private int GetMaxDepth(TreeNode root, int currentDepth)
        {
            var leftDepth = 0;
            var rightDepth = 0;

            if (root.left != null)
                leftDepth = GetMaxDepth(root.left, currentDepth + 1);
            if (root.right != null)
                rightDepth = GetMaxDepth(root.right, currentDepth + 1);

            if (leftDepth == 0 && rightDepth == 0) 
                return currentDepth;
            return Math.Max(leftDepth, rightDepth);
        }
    }
}

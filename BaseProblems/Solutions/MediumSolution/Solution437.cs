using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution437
    {
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null) return 0;

            return DFS(root, targetSum) +
                PathSum(root.left, targetSum) +
                PathSum(root.right, targetSum);
        }

        private int DFS(TreeNode root, long targetSum)
        {
            var count = root.val == targetSum ? 1 : 0;

            if (root.left != null)
                count += DFS(root.left, targetSum - root.val);

            if (root.right != null)
                count += DFS(root.right, targetSum - root.val);

            return count;
        }
    }
}

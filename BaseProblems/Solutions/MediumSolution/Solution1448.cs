using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1448
    {
        public int GoodNodes(TreeNode root)
        {
            return GetGoodNodesCount(root, -10001);
        }

        public int GetGoodNodesCount(TreeNode root, int maxNodeValue) 
        {
            var sum = root.val >= maxNodeValue ? 1 : 0;
            maxNodeValue = Math.Max(maxNodeValue, root.val);
            if (root.left != null)
                sum += GetGoodNodesCount(root.left, maxNodeValue);
            if (root.right != null)
                sum += GetGoodNodesCount(root.right, maxNodeValue);
            return sum;
        }
    }
}

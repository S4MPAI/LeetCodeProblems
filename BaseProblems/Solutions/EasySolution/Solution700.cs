using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution700
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null)
            {
                if (val == root.val)
                    return root;

                if (val < root.val)
                    root = root.left;
                else if (val > root.val)
                    root = root.right;
            }

            return root;
        }
    }
}

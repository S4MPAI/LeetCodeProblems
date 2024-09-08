using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1367
    {
        public bool IsSubPath(ListNode head, TreeNode root)
        {
            if (head == null) 
                return true;
            if (root == null)
                return false;

            return DFS(head, root) || IsSubPath(head, root.left) || IsSubPath(head, root.right);
        }

        private bool DFS(ListNode head, TreeNode root)
        {
            if (head == null) return true;
            if (root == null) return false;
            if (root.val != head.val) return false;
            return DFS(head.next, root.left) || DFS(head.next, root.right);
        }
    }
}

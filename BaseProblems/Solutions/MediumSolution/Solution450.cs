using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution450
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            return DeleteNodeHelper(root, key);
        }

        private TreeNode DeleteNodeHelper(TreeNode node, int key)
        {
            if (node == null)
                return null;

            node.left = DeleteNodeHelper(node.left, key);
            node.right = DeleteNodeHelper(node.right, key);

            if (node.val != key)
                return node;

            if (node.left == null)
                return node.right;

            if (node.right == null)
                return node.left;

            return MoveLeftToRight(node);
        }

        private TreeNode MoveLeftToRight(TreeNode node)
        {
            var leftNode = node.left;
            var rightNode = node.right;
            var baseRight = node.right;

            while (rightNode.left != null)
                rightNode = rightNode.left;

            rightNode.left = leftNode;

            return baseRight;
        }
    }
}

using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution872
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var firstTreeStack = new Stack<TreeNode>();
            var secondTreeStack = new Stack<TreeNode>();
            firstTreeStack.Push(root1);
            secondTreeStack.Push(root2);

            while (firstTreeStack.Count != 0 || secondTreeStack.Count != 0)
            {
                var firstNode = firstTreeStack.Count != 0 ? firstTreeStack.Pop() : new TreeNode(-1);
                var secondNode = secondTreeStack.Count != 0 ? secondTreeStack.Pop() : new TreeNode(-1);
                firstNode = GetLeaf(firstTreeStack, firstNode);
                secondNode = GetLeaf(secondTreeStack, secondNode);

                if (firstNode.val < 0 || secondNode.val < 0 || firstNode.val != secondNode.val)
                    return false;
            }

            return true;
        }

        private static TreeNode GetLeaf(Stack<TreeNode> treeStack, TreeNode node)
        {
            while (node.val >= 0 && (node.left != null || node.right != null))
            {
                if (node.right != null)
                    treeStack.Push(node.right);
                if (node.left != null)
                    treeStack.Push(node.left);
                node = treeStack.Pop();
            }

            return node;
        }
    }
}

using BaseProblems.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution199
    {
        public IList<int> RightSideView(TreeNode root)
        {
            if (root == null)
                return new List<int>();

            var queueNodes = new Queue<TreeNode>();
            var result = new List<int>();
            queueNodes.Enqueue(root);

            while (queueNodes.Any())
            {
                var rightSideNode = 0;
                var nextNodes = new Queue<TreeNode>();

                while (queueNodes.Any()) 
                {
                    var node = queueNodes.Dequeue();

                    if (node.left != null)
                        nextNodes.Enqueue(node.left);

                    if (node.right != null)
                        nextNodes.Enqueue(node.right);

                    rightSideNode = node.val;
                }

                queueNodes = nextNodes;
                result.Add(rightSideNode);
            }

            return result;
        }
    }
}

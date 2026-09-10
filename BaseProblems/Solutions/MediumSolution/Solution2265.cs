using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution2265
{
    public int AverageOfSubtree(TreeNode root)
    {
        var result = 0;
        AverageOfSubtree(root);

        (int sum, int count) AverageOfSubtree(TreeNode root)
        {
            if (root == null)
                return (0, 0);

            var (leftSum, leftCount) = AverageOfSubtree(root.left);
            var (rightSum, rightCount) = AverageOfSubtree(root.right);

            var sum = leftSum + rightSum + root.val;
            var count = leftCount + rightCount + 1;

            var average = sum / count;
            if (average == root.val)
                result++;

            return (sum, count);
        }

        return result;
    }
}

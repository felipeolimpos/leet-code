namespace LeetCode
{
    // Definition for a binary tree node.
    public class TreeNode
    {
        public TreeNode(int x) { val = x; }
        public int val;
        public TreeNode left;
        public TreeNode right;
    }

    public partial class Program
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        public bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            if (left == null || right == null)
            {
                return false;
            }

            return left.val == right.val
                    &&
                    IsMirror(left.left, right.right)
                    &&
                    IsMirror(left.right, right.left);
        }
    }
}
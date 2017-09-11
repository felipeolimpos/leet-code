namespace LeetCode
{
    // Definition for a binary tree node.
    /*public class TreeNode
    {
        public TreeNode(int x) { val = x; }
        public int val;
        public TreeNode left;
        public TreeNode right;
    }*/
    
    public partial class Program
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root != null)
            {
                TreeNode aux = root.left;
                root.left = InvertTree(root.right);
                root.right = InvertTree(aux);
            }

            return root;
        }
    }
}
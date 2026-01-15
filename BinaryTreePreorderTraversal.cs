/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        preorderRecursive(root, result);
        return result;
    }

    public void preorderRecursive(TreeNode root, List<int> result) {
        if(root == null) {
            return; //Don't want to go further from here since it doesn't exist, base case in essence
        }
        result.Add(root.val);
        preorderRecursive(root.left, result);
        preorderRecursive(root.right, result);
    }
}

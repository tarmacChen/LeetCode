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
        List<int>result = new List<int>();
        Stack<TreeNode>stack = new Stack<TreeNode>();
        while(root != null || !(stack.Count == 0)){
            if(root != null){
                stack.Push(root);
                result.Add(root.val);
                root = root.left;
            } else {
                root = stack.Pop();
                // stack.Pop();
                root = root.right;
            }
                
        }
        return result;
    }
}
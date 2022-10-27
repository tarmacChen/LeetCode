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
    public bool IsBalanced(TreeNode root) {
        if(Depth(root) == -1){
            return false;
        } else {
            return true;
        }
    }
    public int Depth(TreeNode node){
        if(node == null){
            return 0;
        }   
        int d1 = Depth(node.left);
        int d2 = Depth(node.right);
        
        if(d1 == -1 || d2 == -1 || Math.Abs(d1-d2)>1){
            return -1;
        } else {
            return Math.Max(d1, d2)+1;   
        }
    }
}
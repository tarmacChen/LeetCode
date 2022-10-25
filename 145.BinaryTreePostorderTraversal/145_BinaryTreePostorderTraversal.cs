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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int>result = new List<int>();
        Stack<TreeNode>stack = new Stack<TreeNode>();
        Dictionary<TreeNode, int> map = new Dictionary<TreeNode, int>();
        while(root != null || !(stack.Count == 0)){
            if(root != null){
                stack.Push(root);
                root = root.left;
            } else {
                root = stack.Peek();
                if(!map.ContainsKey(root)){
                    map[root] = 1;
                    root = root.right;
                } else {
                    result.Add(root.val);
                    stack.Pop();
                    root = null;
                }        
            }   
        }
        return result;
    }
}
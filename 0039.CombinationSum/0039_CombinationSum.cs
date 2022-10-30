public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {    
        if(candidates.Length == 0){
            return null;
        }
        IList<IList<int>> ans = new List<IList<int>>();
        List<int> comb = new List<int>();
        dfs(candidates, target, 0, comb, ans);
        return ans;
    }
    void dfs(int[] candidates, int target, int start, List<int> comb, IList<IList<int>> ans){
        if(target < 0){
            return;
        }
        if(target == 0){
            List<int> newComb = new List<int>();
            foreach(int c in comb){
                newComb.Add(c);
            }
            ans.Add(newComb);
            return;
        }
        
        for(int i = start; i < candidates.Length; i++){
            comb.Add(candidates[i]);
            dfs(candidates, target-candidates[i], i, comb, ans);
            comb.RemoveAt(comb.Count-1);    
        }
    }
}
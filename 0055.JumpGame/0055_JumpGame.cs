public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length;
        int maxDis = 0;
        for(int i=0; i<n; i++){
            if(maxDis < i){
                return false;
            }
            maxDis = Math.Max(maxDis, i+nums[i]);
            if(maxDis >= n-1){
                return true;
            }
        }
        return false;
    }
}
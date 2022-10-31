public class Solution {
    public int MaxSubArray(int[] nums) {
        int res = Int32.MinValue;
        int curSum = 0;
        foreach(int n in nums){
            curSum = Math.Max(curSum+n, n);
            res = Math.Max(res, curSum);
        }
        return res;
    }
}
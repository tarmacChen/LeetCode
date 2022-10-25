public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] result = new int[] {-1, -1};
        if(nums.Length == 0){
            return result;
        }
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == target){
                if(result[0] == -1){
                    result[0] = i; 
                }
                result[1] = i;
            }
        }
        return result;
    }
}
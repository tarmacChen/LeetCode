public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0;
        int end = nums.Length-1;
        
        while(start+1 < end){
            int mid = (start+end)/2;
            if(nums[mid] == target){
                return mid;
            }
            if(nums[start] < nums[mid]){
                if(nums[start] <= target && target < nums[mid]){
                    end = mid;
                } else {
                    start = mid;
                }
            } else {
                if(nums[mid] < target && target <= nums[end]){
                    start = mid;
                } else {
                    end = mid;
                }
            }
        }
        if(nums[start] == target){
            return start;
        }
        else if(nums[end] == target){
            return end;
        }
        return -1;
    }
}
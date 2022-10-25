public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);   
        IList<IList<int>> result = new List<IList<int>>();
        for(int i = 0; i < nums.Length; i++) {
            if(i > 0 && nums[i-1] == nums[i]) continue;
            int left = i + 1;
            int right = nums.Length - 1;
            while(left < right){
                int expectSum = nums[i] + nums[left] + nums[right];
                if(expectSum > 0) {
                    right--;
                } 
                else if(expectSum < 0) {
                    left++;
                } else {
                    result.Add(new List<int>{nums[i], nums[left], nums[right]});
                    left++;
                    while(nums[left] == nums[left - 1] && left < right){
                        left++;
                    }
                }      
            }
        }
        return (IList<IList<int>>)result;
    }
}

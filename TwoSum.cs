public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int remain = target - nums[i];
            if (hashMap.ContainsKey(remain)) {
                return new int[2] { hashMap[remain], i };
            }
            if (!hashMap.ContainsKey(nums[i])) {
                hashMap.Add(nums[i], i);
            }
        }
        return new int[] {};
    }
}

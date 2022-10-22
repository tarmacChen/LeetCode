public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;
        while(left != right){
            int bottomLength = right - left;
            int area = bottomLength * Math.Min(height[left], height[right]);
            if(area > maxArea) maxArea = area;
            if(height[left] >= height[right]){
                right--;
            } else {
                left++;
            }
        }
        return maxArea;
    }
}

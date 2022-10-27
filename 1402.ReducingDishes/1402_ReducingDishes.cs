public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction);
        Array.Reverse(satisfaction);
        int n = satisfaction.Length;
        int max = 0;
        while(n > 0){
            int preSum = 0;
            int multi = 1;
            for(int i = n - 1; i >= 0; i--){
                preSum += satisfaction[i] * multi; 
                multi++;
            }
            max = Math.Max(max, preSum);
            n--;
        }
        return max;
    }
}
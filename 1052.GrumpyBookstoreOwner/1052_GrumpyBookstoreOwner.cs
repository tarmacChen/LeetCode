public class Solution {
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
        int sum = 0;
        int n = grumpy.Length;
        for(int i = 0; i < n; i++){
            if(grumpy[i] == 0){
                sum += customers[i];
            }
        }
        
        int ret = 0;
        for(int i = 0; i < n; i++){
            if(grumpy[i] == 1){
                sum += customers[i];
            }
            if(i >= minutes && grumpy[i-minutes] == 1){
                sum -= customers[i-minutes];
            }
            ret = Math.Max(ret, sum);
        }
        return ret;
    }
}
public class Solution {
    public int FindJudge(int n, int[][] trust) {
        int[] inner = new int[n];
        int[] outter = new int[n];
        int ans = -1;
        for(int i = 0; i < trust.Length; i++){
            outter[trust[i][0] - 1]++;
            inner[trust[i][1] -1]++;
        }
        for(int i = 0; i < n; i++){
            if(outter[i] == 0 && inner[i] == n-1){
                if(ans == -1){
                    ans = i + 1;
                } else {
                    return -1;
                }
            }
        }
        return ans;
    }
}
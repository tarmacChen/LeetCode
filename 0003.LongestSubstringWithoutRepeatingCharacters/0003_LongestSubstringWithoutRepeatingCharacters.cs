public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        int i = 0;
        Dictionary<int, int> lastPos = new Dictionary<int, int>();
        for(int idx = 0; idx < s.Length; idx++){
            if(lastPos.ContainsKey(s[idx])){
                i = Math.Max(i, lastPos[s[idx]]+1);
            } else {
                lastPos.Add(s[idx], idx);
            }
            lastPos[s[idx]]  = idx;
            max = Math.Max(max,  idx-i+1);
        }
        return max;
    }
}
public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals.Length == 0){
            return intervals;   
        }
        intervals = intervals.OrderBy(p => p[0]).ToArray();
        
        List<int[]> list = new List<int[]>();
        for(int i = 0; i < intervals.Length-1; i++){
            if(intervals[i][1] >= intervals[i + 1][0]){
                intervals[i + 1][0] = intervals[i][0];
                
                if(intervals[i][1] >= intervals[i + 1][1]){
                    intervals[i + 1][1] = intervals[i][1];
                }
            } else {
                list.Add(intervals[i]);
            }
        }
        list.Add(intervals[intervals.Length-1]);
        int[][]result = list.ToArray();
        return result;
    }
}
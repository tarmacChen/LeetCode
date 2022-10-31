public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> res = new List<int>();
        if(matrix.Length == 0){
            return res;
        }
        int rowBegin = 0;
        int rowEnd = matrix.Length-1;
        int colBegin = 0;
        int colEnd = matrix[0].Length-1;
        
        while(rowBegin <= rowEnd && colBegin <= colEnd){
            for(int j = colBegin; j <= colEnd; j++){
                res.Add(matrix[colBegin][j]);
            }
            rowBegin++;
            
            for(int j = rowBegin; j <= rowEnd; j++){
                res.Add(matrix[j][colEnd]);
            }
            colEnd--;
            
            if(rowBegin <= rowEnd){
                for(int j = colEnd; j >= colBegin; j--){
                    res.Add(matrix[rowEnd][j]);
                }
            }
            rowEnd--;
            
            if(colBegin <= colEnd){
                for(int j = rowEnd; j >= rowBegin; j--){
                    res.Add(matrix[j][colBegin]);
                }
            }
            colBegin++;
        }
        return res;
    }
}
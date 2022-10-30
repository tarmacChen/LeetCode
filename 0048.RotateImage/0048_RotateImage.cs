public class Solution {
    public void Rotate(int[][] matrix) {
        if(matrix.Length == 0){
            return;
        }
        Transpose(ref matrix);
        for(int i = 0; i < matrix.Length; i++){
            Reverse(ref matrix[i]);
        }
    }
    public void swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }
    public void Transpose(ref int[][] matrix){
        int mlen = matrix.Length;
        for(int i = 0; i < mlen; i++){
            for(int j = i+1; j < mlen; j++){
                swap(ref matrix[i][j], ref matrix[j][i]);
            }
        }
    }
    public void Reverse(ref int[] v){
        int vlen = v.Length;
        for(int i = 0; i < vlen/2; i++){
            swap(ref v[i], ref v[vlen-1-i]);
        }
    }
}


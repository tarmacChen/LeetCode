    public class Solution {
        public void SetZeroes(int[][] matrix) {
            if (matrix.Length == 0) {
                return;
            }
            int row = 1;
            int col = 1;
            int pos = 1;
            int count = matrix.Length * matrix[0].Length;
            List<int[]> cache = new List<int[]>();
            while (pos <= count) {
                if (col == matrix[0].Length + 1) {
                    row++;
                    col = 1;
                }
                if (matrix[row - 1][col - 1] == 0) {
                    for (int i = 0; i < matrix[0].Length; i++) {
                        cache.Add(new int[] { row - 1, i });
                    }
                    for (int i = 0; i < matrix.Length; i++) {
                        cache.Add(new int[] { i, col - 1 });
                    }
                }
                col++;
                pos++;
            }
            foreach (var c in cache) {
                matrix[c[0]][c[1]] = 0;
            }
        }
    }
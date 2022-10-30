public class Solution {
    public int Find(int[] p, int x){
        if(p[x] != x){
            p[x] = Find(p, p[x]);
        }
        return p[x];
    }
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        int[] p = new int[n];
        for(int i = 0; i < p.Length; i++){
            p[i] = i;
        }
        
        foreach(int[] edge in edges){
            p[Find(p, edge[0])] = Find(p, edge[1]);
        }
        return Find(p, source) == Find(p, destination);
    }
}
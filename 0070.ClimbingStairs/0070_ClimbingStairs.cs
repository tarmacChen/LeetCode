public class Solution {
    public int ClimbStairs(int n) {
        double a1 = 1 / Math.Sqrt(5);
        double b2 = Math.Pow((1 + Math.Sqrt(5)) / 2, n+1);
        double c3 = Math.Pow((1 - Math.Sqrt(5)) / 2, n+1);
        int fx = (int)(a1 * (b2 - c3));
        return fx;
    }
}
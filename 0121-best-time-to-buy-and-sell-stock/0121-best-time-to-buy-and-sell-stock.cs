public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue, diff = -1;
        foreach(var price in prices) {
            min = Math.Min(min, price);
            diff = Math.Max(diff, price - min);
        };
        return diff;
    }
}
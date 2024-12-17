public class Solution {
    public int MaxProfit(int[] prices) {
        int max = -1, min = int.MaxValue, diff = max - min;
        foreach(var price in prices) {
            if (price > max)
                max = price;
                if (max - min > diff)
                    diff = max - min;
            if (price < min) 
                min = price;
                max = price;
                if (max - min > diff)
                    diff = max - min;
        };
        return diff;
    }
}
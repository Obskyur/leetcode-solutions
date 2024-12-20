public class Solution {
    public bool IsHappy(int n) {
        var results = new Dictionary<int, int>();
        int curVal = n;

        while (curVal != 1) {
            int prevVal = curVal;
            if (results.ContainsKey(curVal)) {
                return false;
            }
            curVal = sumSquareDigits(curVal);
            results.Add(prevVal, curVal);
        }

        return true;
    }

    private int sumSquareDigits(int n) {
        int sum = 0;
        while (n > 0) {
            sum += (int)Math.Pow(n % 10, 2);
            n /= 10;
        }
        return sum;
    }
}
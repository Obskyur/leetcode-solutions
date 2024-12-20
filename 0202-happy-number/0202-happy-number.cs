public class Solution {
    public bool IsHappy(int n) {
        var results = new HashSet<int>();
        int curVal = n;

        while (curVal != 1) {
            if (results.Contains(curVal)) {
                return false;
            }
            results.Add(curVal);
            curVal = sumSquareDigits(curVal);
        }

        return true;
    }

    private int sumSquareDigits(int n) {
        int sum = 0;
        while (n > 0) {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
}
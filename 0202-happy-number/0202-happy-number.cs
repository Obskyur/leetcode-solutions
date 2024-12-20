public class Solution {
    public bool IsHappy(int n) {
        var results = new HashSet<int>();

        while (n != 1) {
            if (results.Contains(n)) {
                return false;
            }
            results.Add(n);
            n = sumSquareDigits(n);
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
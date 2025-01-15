public class Solution {
    public int GetLargestOutlier(int[] nums) {
        int sum = 0;
        int outlier = int.MinValue;
        var freq = new Dictionary<int, int>();
        foreach (int num in nums) {
            sum += num;
            freq[num] = freq.GetValueOrDefault(num, 0) + 1;
        }
        foreach (int num in nums) {
            int outlierCandidate = sum - 2 * num;
            if (!freq.ContainsKey(outlierCandidate)) 
                continue;
            if (outlierCandidate == num && freq[outlierCandidate] < 2)
                continue;
            outlier = Math.Max(outlier, outlierCandidate);
        }

        return outlier;
    }
}
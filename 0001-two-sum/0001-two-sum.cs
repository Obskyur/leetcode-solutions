public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexOfNum = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int curVal = nums[i];
            int numNeeded = target - curVal;
            if (indexOfNum.ContainsKey(numNeeded)) {
                return new int[] { indexOfNum[numNeeded], i };
            }
            indexOfNum.TryAdd(curVal, i);
        }
        throw new ArgumentException("Target not found from sum of two values in nums.");
    }
}
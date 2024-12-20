public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexOfNum = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int curVal = nums[i];
            if (indexOfNum.ContainsKey(target - curVal)) {
                return new int[] { indexOfNum[target - curVal], i };
            }
            indexOfNum.TryAdd(curVal, i);
        }
        throw new ArgumentException("Target not found from sum of two values in nums.");
    }
}
public class Solution {
    public int MinimumOperations(int[] nums) {
        var distinct = new HashSet<int>();
        int i = nums.Length - 1;

        while (i >= 0 && distinct.Add(nums[i]))
            i--;

        return i < 0 ? 0 : (i + 3) / 3;
    }
}
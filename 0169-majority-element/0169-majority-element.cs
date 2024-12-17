public class Solution {
    public int MajorityElement(int[] nums) {
        return nums
            .GroupBy(num => num)
            .OrderByDescending(group => group.Count())
            .First()
            .Key;
    }
}
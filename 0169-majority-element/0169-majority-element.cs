public class Solution {
    public int MajorityElement(int[] nums) {
        var freq = nums.GroupBy(num => num);
        int max = -1, retval = -1;
        foreach(var group in freq) {
            if (group.Count() > max) {
                max = group.Count();
                retval = group.Key;
            }
        }
        return retval;
    }
}
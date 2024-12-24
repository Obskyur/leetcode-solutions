public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var outList = new List<string>();

        for (int i = 0; i < nums.Length; i++) {
            var (start, end) = GetRange(nums, ref i);
            AddRangeToList(outList, (start, end));
        }
        return outList;
    }

    private (int, int) GetRange(int[] nums, ref int i) {
        int start = nums[i];
        while (i < nums.Length - 1 && nums[i + 1] - nums[i] == 1)
            i++;
        int end = nums[i];
        return (start, end);
    }

    private void AddRangeToList(List<string> list, (int start, int end) range) {
            if (range.start == range.end)
                list.Add($"{range.start}");
            else
                list.Add($"{range.start}->{range.end}");
    }
}
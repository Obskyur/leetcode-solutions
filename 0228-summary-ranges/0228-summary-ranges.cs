public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var outList = new List<string>();        
        int start, end;

        for (int i = 0; i < nums.Length; i++) {
            start = nums[i];
            while (i < nums.Length - 1 && nums[i + 1] - nums[i] == 1)
                i++;
            end = nums[i];
            
            if (start == end)
                outList.Add($"{start}");
            else
                outList.Add($"{start}->{end}");
        }
        return outList;
    }
}
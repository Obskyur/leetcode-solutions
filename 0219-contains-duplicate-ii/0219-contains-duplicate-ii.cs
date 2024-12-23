public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var indices = new Dictionary<int, int>();
        

        foreach (var (num, i) in nums.Select((num, i) => (num, i))) {
            if (indices.ContainsKey(num)) {
                if (Math.Abs(indices[num] - i) <= k)
                    return true;
                indices[num] = i;
            }
            else
                indices.Add(num, i);
        }
        return false;
    }
}
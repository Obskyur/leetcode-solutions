public class Solution {
    public int[][] Merge(int[][] intervals) => 
        intervals.OrderBy(i => i[0]).Aggregate(new List<int[]>(), (res, cur) => {
            if (res.Count == 0 || res[^1][1] < cur[0])
                res.Add(cur);
            else
                res[^1][1] = Math.Max(res[^1][1], cur[1]);
            return res;
        }).ToArray();
}
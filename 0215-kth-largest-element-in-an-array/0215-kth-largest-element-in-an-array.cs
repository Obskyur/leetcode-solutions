public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y - x));
        var numsToCount = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (numsToCount.ContainsKey(num))
                numsToCount[num]++;
            else {
                numsToCount.Add(num, 1);
                pq.Enqueue(num, num);
            }
        }
        int res = -1;
        for (; k > 0; k--) {
            res = pq.Peek();
            if (numsToCount[res] > 1) {
                numsToCount[res]--;
            }
            else
                pq.Dequeue();
        }
        return res;
    }
}
public class Solution {
    public int Trap(int[] height) {
        int res = 0;
        int l = 0;
        int r = height.Length - 1;
        int maxL = height[l];
        int maxR = height[r];
        while (l < r) {
            if (maxL <= maxR) {
                l++;
                res += Math.Max(0, maxL - height[l]);
                maxL = Math.Max(maxL, height[l]);
            } else {
                r--;
                res += Math.Max(0, maxR - height[r]);
                maxR = Math.Max(maxR, height[r]);
            }
        }

        return res;
    }
}
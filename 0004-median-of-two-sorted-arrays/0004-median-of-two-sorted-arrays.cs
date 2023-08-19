public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] merged = nums1.Concat(nums2).ToArray();
        Array.Sort(merged);

        int totalLength = merged.Length;
        if (totalLength % 2 == 0) {
            int mid1 = totalLength / 2;
            int mid2 = mid1 - 1;
            return (merged[mid1] + merged[mid2]) / 2.0;
        } else {
            int median = totalLength / 2;
            return merged[median];
        }
    }
}

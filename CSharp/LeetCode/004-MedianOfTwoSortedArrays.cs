namespace LeetCode
{
    public class _004_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            return FindKth(nums1, 0, nums2, 0, (nums1.Length + nums2.Length) / 2);
        }

        double FindKth(int[] nums1, int startIndex1, int[] nums2, int startIndex2, int k)
        {
            if (nums1.Length - startIndex1 < nums2.Length - startIndex2) { return FindKth(nums2, startIndex2, nums1, startIndex1, k); }
            if (nums2.Length <= startIndex2) { return nums1[k]; }
            if (k == 1) { return nums1[startIndex1] < nums2[startIndex2] ? nums1[startIndex1] : nums2[startIndex2]; }

            var index1 = k / 2 + startIndex1 < nums1.Length - startIndex1 ? k / 2 : nums1.Length - startIndex1;
            var index2 = k - index1 + startIndex2;
            if (nums1[index1] > nums2[index2])
            {
                return FindKth(nums1, startIndex1, nums2, index2, k - index2 + startIndex2);
            }
            else if (nums1[index1] < nums2[index2])
            {
                return FindKth(nums1, index1, nums2, startIndex2, k - index1 + startIndex1);
            }
            else
            {
                return nums1[index1 - 1];
            }
        }
    }
}

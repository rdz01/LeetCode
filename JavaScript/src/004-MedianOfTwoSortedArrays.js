var solution = function() {
    'use strict';

    /**
     * @param {number[]} nums1
     * @param {number[]} nums2
     * @return {number}
     */
    var findMedianSortedArrays = function(nums1, nums2) {
        var m = nums1.length + nums2.length;

        if (m % 2 !== 0) {
            return findKth(nums1, 0, nums2, 0, (m + 1) / 2);
        } else {
            return (findKth(nums1, 0, nums2, 0, m / 2) + findKth(nums1, 0, nums2, 0, m / 2 + 1)) / 2.0;
        }
    };

    var findKth = function(nums1, startIndex1, nums2, startIndex2, k) {
        var nums1Left = nums1.length - startIndex1;
        var nums2Left = nums2.length - startIndex2;

        if (nums1Left < nums2Left) {
            return findKth(nums2, startIndex2, nums1, startIndex1, k);
        }
        if (nums2Left <= 0) {
            return nums1[startIndex1 + k - 1];
        }
        if (k === 1) {
            return nums1[startIndex1] < nums2[startIndex2] ? nums1[startIndex1] : nums2[startIndex2];
        }

        var index1 = parseInt(k / 2) < nums1Left ? parseInt(k / 2) : nums1Left;
        var index2 = k - index1 < nums2Left ? k - index1 : nums2Left;
        if (nums1[startIndex1 + index1 - 1] > nums2[startIndex2 + index2 - 1]) {
            return findKth(nums1, startIndex1, nums2, startIndex2 + index2, k - index2);
        } else if (nums1[startIndex1 + index1 - 1] < nums2[startIndex2 + index2 - 1]) {
            return findKth(nums1, startIndex1 + index1, nums2, startIndex2, k - index1);
        } else {
            return nums1[startIndex1 + index1 - 1];
        }
    };

    return {
        findMedianSortedArrays: findMedianSortedArrays
    };
};

module.exports = solution();

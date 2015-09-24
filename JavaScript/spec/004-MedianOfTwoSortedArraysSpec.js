var solution = require('../src/004-MedianOfTwoSortedArrays.js');

describe('Median of Two Sorted Arrays Test', function() {
    'use strict';

    it('should return the median when the total count is odd', function() {
        var nums1 = [
            1, 2, 3
        ];
        var nums2 = [
            4, 5
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(3);
    });

    it('should return the median when the total count is even', function() {
        var nums1 = [
            1, 2, 3, 4
        ];
        var nums2 = [
            5, 6, 7, 8
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(4.5);
    });

    it('should return the median when nums1 is empty', function() {
        var nums1 = [];
        var nums2 = [
            1, 2, 3
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(2);
    });

    it('should return the median when nums2 is empty', function() {
        var nums1 = [
            1, 2, 3
        ];
        var nums2 = [];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(2);
    });

    it('should return the median when nums1 is empty and nums2 only have 1 item', function() {
        var nums1 = [];
        var nums2 = [
            1
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(1);
    });

    it('should return the median when nums2 is empty and nums1 only have 1 item', function() {
        var nums1 = [
            1
        ];
        var nums2 = [];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(1);
    });

    it('should return the median when nums1 only have 1 item and total count is odd', function() {
        var nums1 = [
            1
        ];
        var nums2 = [
            2, 3, 4, 5, 6, 7
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(4);
    });

    it('should return the median when nums1 only have 1 item and total count is even', function() {
        var nums1 = [
            1
        ];
        var nums2 = [
            2, 3, 4, 5, 6
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(3.5);
    });

    it('should return the median when nums1 only have 2 item and total count is odd', function() {
        var nums1 = [
            2, 3, 4, 5, 6, 7
        ];
        var nums2 = [
            1
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(4);
    });

    it('should return the median when nums1 only have 2 item and total count is even', function() {
        var nums1 = [
            2, 3, 4, 5, 6
        ];
        var nums2 = [
            1
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(3.5);
    });

    it('should return the median when total count is even and two items in different arrays', function() {
        var nums1 = [
            2
        ];
        var nums2 = [
            1, 3, 4
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(2.5);
    });

    it('should return the median when there have duplicate items', function() {
        var nums1 = [
            1, 1, 3, 3
        ];
        var nums2 = [
            1, 1, 3, 3
        ];
        var result = solution.findMedianSortedArrays(nums1, nums2);

        expect(result).toEqual(2);
    });
});

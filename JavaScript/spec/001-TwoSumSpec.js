var solution = require('../src/001-TwoSum');

describe('Two Sum Tests', function() {
    'use strict';

    var largeArray = new Array(20000);

    beforeAll(function() {
        for (var i = 0; i < largeArray.length; i++) {
            largeArray[i] = i * 2;
        }
    });

    it('should get result when array is ordered', function() {
        var nums = [
            2, 7, 11, 15
        ];
        var target = 9;

        var result = solution.twoSum(nums, target);

        expect(result.length).toEqual(2);
        expect(result[0]).toEqual(1);
        expect(result[1]).toEqual(2);
    });

    it('should get result when array is unordered', function() {
        var nums = [
            5, 75, 25
        ];
        var target = 100;

        var result = solution.twoSum(nums, target);

        expect(result.length).toEqual(2);
        expect(result[0]).toEqual(2);
        expect(result[1]).toEqual(3);
    });

    it('should get result when array has duplicate numbers', function() {
        var nums = [
            5, 5, 15, 30
        ];
        var target = 20;

        var result = solution.twoSum(nums, target);

        expect(result.length).toEqual(2);
        expect(result[0]).toEqual(2);
        expect(result[1]).toEqual(3);
    });

    it('should get result when array\'s items are all the same', function() {
        var nums = [
            5, 5, 5, 5
        ];
        var target = 10;

        var result = solution.twoSum(nums, target);

        expect(result.length).toEqual(2);
        expect(result[0]).toEqual(1);
        expect(result[1]).toEqual(2);
    });

    it('should not get result when non of the sum is the target', function() {
        var nums = [
            2, 7, 11, 15
        ];
        var target = 5;

        var result = solution.twoSum(nums, target);

        expect(result.length).toEqual(0);
    });

    it('should get result even the array is large', function() {
        var target = 19082;

        var result = solution.twoSum(largeArray, target);

        expect(result.length).toEqual(2);
        expect(result[0]).toEqual(4771);
        expect(result[1]).toEqual(4772);
    });

    it('should not get result when non of the sum is the target, even the array is large', function() {
        var target = 19081;

        var result = solution.twoSum(largeArray, target);

        expect(result.length).toEqual(0);
    });
});

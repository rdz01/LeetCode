var solution = function() {
    'use strict';

    var keys = [];
    var values = [];

    var hash = function(key, size) {
        return (key & 0x7FFFFFFF) % size;
    };

    var initialize = function(size) {
        keys = new Array(size);
        values = new Array(size);

        for (var i = 0; i < size; i++) {
            keys[i] = -1;
        }
    };

    var put = function(key, value, size) {
        var i = 0;
        for (i = hash(key, size); keys[i] !== -1; i = (i + 1) % size) {
            if (keys[i] === key) {
                values[i] = value;
            }
        }
        keys[i] = key;
        values[i] = value;
    };

    var get = function(key, size) {
        for (var i = hash(key, size); keys[i] !== -1; i = (i + 1) % size) {
            if (keys[i] === key) {
                return values[i];
            }
        }
        return -1;
    };

    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    var twoSum = function(nums, target) {
        initialize(nums.length);

        for (var i = 0; i < nums.length; i++) {
            if (get(nums[i], nums.length) === -1) {
                put(target - nums[i], i, nums.length);
            } else {
                var result = [];
                result[0] = get(nums[i], nums.length) + 1;
                result[1] = i + 1;
                return result;
            }
        }
        return [];
    };

    return {
        twoSum: twoSum
    };
};

module.exports = solution();

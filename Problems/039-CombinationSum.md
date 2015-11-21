# Combination Sum

Given a set of candidate numbers (***C***) and a target number (***T***), find all unique combinations in ***C*** where the candidate numbers sums to ***T***.

The **same** repeated number may be chosen from ***C*** unlimited number of times.

**Note:**

- All numbers (including target) will be positive integers.
- Elements in a combination (*a*<sub>1</sub>, *a*<sub>2</sub>, … , *a*<sub>k</sub>) must be in non-descending order. (ie, *a*<sub>1</sub> ≤ *a*<sub>2</sub> ≤ … ≤ *a*<sub>k</sub>).
- The solution set must not contain duplicate combinations.

For example,

> given candidate set `2,3,6,7` and target `7`,
> 
> A solution set is: 
> 
> `[7]`
> 
> `[2, 2, 3] `

## Solution Sketch

### C++
```C++
class Solution {
public:
    vector<vector<int>> combinationSum(vector<int>& candidates, int target) {

    }
};
```

### Java
```Java
public class Solution {
    public List<List<Integer>> combinationSum(int[] candidates, int target) {

    }
}
```

### Python
```Python
class Solution(object):
    def combinationSum(self, candidates, target):
        """
        :type candidates: List[int]
        :type target: int
        :rtype: List[List[int]]
        """
```

### C
```C
/**
 * Return an array of arrays of size *returnSize.
 * The sizes of the arrays are returned as *columnSizes array.
 * Note: Both returned array and *columnSizes array must be malloced, assume caller calls free().
 */
int** combinationSum(int* candidates, int candidatesSize, int target, int** columnSizes, int* returnSize) {

}
```

### C# 
```C#
public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {

    }
}
```

### JavaScript
```JavaScript
/**
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum = function(candidates, target) {

};
```

### Ruby
```Ruby
# @param {Integer[]} candidates
# @param {Integer} target
# @return {Integer[][]}
def combination_sum(candidates, target)

end
```

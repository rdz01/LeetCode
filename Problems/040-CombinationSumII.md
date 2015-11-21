# Combination Sum

Given a collection  of candidate numbers (***C***) and a target number (***T***), find all unique combinations in ***C*** where the candidate numbers sums to ***T***.

Each number in ***C*** may only be used **once** in the combination.

**Note:**

- All numbers (including target) will be positive integers.
- Elements in a combination (*a*<sub>1</sub>, *a*<sub>2</sub>, … , *a*<sub>k</sub>) must be in non-descending order. (ie, *a*<sub>1</sub> ≤ *a*<sub>2</sub> ≤ … ≤ *a*<sub>k</sub>).
- The solution set must not contain duplicate combinations.

For example,

> given candidate set `10,1,2,7,6,1,5` and target `8`,
> 
> A solution set is: 
> 
> `[1, 7] `
> 
> `[1, 2, 5] `
> 
> `[2, 6] `
> 
> `[1, 1, 6] `

## Solution Sketch

### C++
```C++
class Solution {
public:
    vector<vector<int>> combinationSum2(vector<int>& candidates, int target) {

    }
};
```

### Java
```Java
public class Solution {
    public List<List<Integer>> combinationSum2(int[] candidates, int target) {

    }
}
```

### Python
```Python
class Solution(object):
    def combinationSum2(self, candidates, target):
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
int** combinationSum2(int* candidates, int candidatesSize, int target, int** columnSizes, int* returnSize) {

}
```

### C# 
```C#
public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {

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
var combinationSum2 = function(candidates, target) {

};
```

### Ruby
```Ruby
# @param {Integer[]} candidates
# @param {Integer} target
# @return {Integer[][]}
def combination_sum2(candidates, target)

end
```

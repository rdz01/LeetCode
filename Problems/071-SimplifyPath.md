# Simplify Path

Given an absolute path for a file (Unix-style), simplify it.

For example,

> **path** = `"/home/"`, => `"/home"`
> 
> **path** = `"/a/./b/../../c/"`, => `"/c"`

**Corner Cases:**

 * Did you consider the case where **path** = `"/../"`? In this case, you should return `"/"`.
 * Another corner case is the path might contain multiple slashes `'/'` together, such as `"/home//foo/"`. In this case, you should ignore redundant slashes and return `"/home/foo"`.

## Solutions Sketch

### C++
```C++
class Solution {
public:
    string simplifyPath(string path) {

    }
};
```

### Java
```Java
public class Solution {
    public String simplifyPath(String path) {

    }
}
```

### Python
```Python
class Solution(object):
    def simplifyPath(self, path):
        """
        :type path: str
        :rtype: str
        """
```

### C
```C
char* simplifyPath(char* path) {

}
```

### C# 
```C#
public class Solution {
    public string SimplifyPath(string path) {

    }
}
```

### JavaScript
```JavaScript
/**
 * @param {string} path
 * @return {string}
 */
var simplifyPath = function(path) {

};
```

### Ruby
```Ruby
# @param {String} path
# @return {String}
def simplify_path(path)

end
```

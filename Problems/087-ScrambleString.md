# Scramble String

Given a string *s1*, we may represent it as a binary tree by partitioning it to two non-empty substrings recursively.

Below is one possible representation of *s1* = `"great"`:

>     great
> 
>    /    \
> 
>   gr    eat
> 
>  / \    /  \
> 
> g   r  e   at
> 
>            / \
> 
>           a   t

We say that `"rgeat"` is a scrambled string of `"great"`.

Similarly, if we continue to swap the children of nodes "eat" and "at", it produces a scrambled string `"rgtae"`.

>     rgtae
> 
>    /    \
> 
>   rg    tae
> 
>  / \    /  \
> 
> r   g  ta  e
> 
>        / \
> 
>       t   a

We say that `"rgtae"` is a scrambled string of `"great"`.

Given two strings *s1* and *s2* of the same length, determine if *s2* is a scrambled string of *s1*.

## Solutions Sketch

### C++
```C++
class Solution {
public:
    bool isScramble(string s1, string s2) {

    }
};
```

### Java
```Java
public class Solution {
    public boolean isScramble(String s1, String s2) {

    }
}
```

### Python
```Python
class Solution(object):
    def isScramble(self, s1, s2):
        """
        :type s1: str
        :type s2: str
        :rtype: bool
        """
```

### C
```C
bool isScramble(char* s1, char* s2) {

}
```

### C# 
```C#
public class Solution {
    public bool IsScramble(string s1, string s2) {

    }
}
```

### JavaScript
```JavaScript
/**
 * @param {string} s1
 * @param {string} s2
 * @return {boolean}
 */
var isScramble = function(s1, s2) {

};
```

### Ruby
```Ruby
# @param {String} s1
# @param {String} s2
# @return {Boolean}
def is_scramble(s1, s2)

end
```

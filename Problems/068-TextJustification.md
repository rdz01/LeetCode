# Text Justification

Given an array of words and a length L, format the text such that each line has exactly L characters and is fully (left and right) justified.

You should pack your words in a greedy approach; that is, pack as many words as you can in each line. Pad extra spaces `' '` when necessary so that each line has exactly L characters.

Extra spaces between words should be distributed as evenly as possible. If the number of spaces on a line do not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.

For the last line of text, it should be left justified and no extra space is inserted between words.

For example,

> **words**: `["This", "is", "an", "example", "of", "text", "justification."]`
> 
> **L**: `16`. 
> 
> Return the formatted lines as:
> 
> ```C
> [
>    "This    is    an",
>    "example  of text",
>    "justification.  "
> ]
> ```

**Note:** Each word is guaranteed not to exceed *L* in length.

## Solutions Sketch

### C++
```C++
class Solution {
public:
    vector<string> fullJustify(vector<string>& words, int maxWidth) {

    }
};
```

### Java
```Java
public class Solution {
    public List<String> fullJustify(String[] words, int maxWidth) {

    }
}
```

### Python
```Python
class Solution(object):
    def fullJustify(self, words, maxWidth):
        """
        :type words: List[str]
        :type maxWidth: int
        :rtype: List[str]
        """
```

### C
```C
/**
 * Return an array of size *returnSize.
 * Note: The returned array must be malloced, assume caller calls free().
 */
char** fullJustify(char** words, int wordsSize, int maxWidth, int* returnSize) {

}
```

### C# 
```C#
public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {

    }
}
```

### JavaScript
```JavaScript
/**
 * @param {string[]} words
 * @param {number} maxWidth
 * @return {string[]}
 */
var fullJustify = function(words, maxWidth) {

};
```

### Ruby
```Ruby
# @param {String[]} words
# @param {Integer} max_width
# @return {String[]}
def full_justify(words, max_width)

end
```

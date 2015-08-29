package bigegg.leetcode;

import java.util.HashMap;
import java.util.Map;

public class _003_LongestSubstringWithoutRepeatingCharacters {
    public int lengthOfLongestSubstring(String s) {
        if (s == null || s.length() == 0) {
            return 0;
        }

        Map<Character, Integer> map = new HashMap<Character, Integer>();
        int maxLen = 0;
        int lastRepeatPos = -1;
        for (int i = 0; i < s.length(); i++) {
            if (map.containsKey(s.charAt(i)) && lastRepeatPos < map.get(s.charAt(i))) {
                lastRepeatPos = map.get(s.charAt(i));
            }
            if (maxLen < i - lastRepeatPos) {
                maxLen = i - lastRepeatPos;
            }
            map.put(s.charAt(i), i);
        }

        return maxLen;
    }
}

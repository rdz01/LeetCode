#include "003-LongestSubstringWithoutRepeatingCharacters.h"

int lengthOfLongestSubstring(char *s)
{
	if (s == NULL) { return 0; }

	int map[256];
	int i;
	int maxLen;
	int lastRepeatPos;

	for (i = 0; i < 256; i++) {
		map[i] = -1;
	}

	maxLen = 0;
	lastRepeatPos = -1;
	for (i = 0; s[i] != '\0'; i++)
	{
		if (map[s[i]] != -1 && lastRepeatPos < map[s[i]])
		{
			lastRepeatPos = map[s[i]];
		}
		if (maxLen < i - lastRepeatPos)
		{
			maxLen = i - lastRepeatPos;
		}
		map[s[i]] = i;
	}

	return maxLen;
}

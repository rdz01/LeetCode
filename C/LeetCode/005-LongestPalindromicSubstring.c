#include "005-LongestPalindromicSubstring.h"

char * longestPalindrome(char *s) {
	if (s == NULL) { return s; }

	int i, n, n2, range_max, center, longestPalindromeCenter, longestPalindromeStartIndex;
	int *p;
	char *s2;
	char *result;

	n = 0;
	while (s[n] != '\0')
	{
		n++;
	}
	if (n < 2) { return s; }

	n2 = n * 2 + 1;
	s2 = (char *)malloc(sizeof(char) * n2);
	for (i = 0; i < n; i++)
	{
		s2[i * 2] = '#';
		s2[i * 2 + 1] = s[i];
	}
	s2[n2 - 1] = '#';

	p = (int *)malloc(sizeof(int) * n2);
	p[0] = 0;
	range_max = center = longestPalindromeCenter = 0;
	for (i = 1; i < n2-1; i++)
	{
		if (range_max > i) 
		{
			p[i] = p[(center << 1) - i] < range_max - i ? p[(center << 1) - i]: range_max - i;
		}
		else
		{
			p[i] = 0;
		}

		while (i - 1 - p[i] >= 0 && i + 1 + p[i] && s2[i - 1 - p[i]] == s2[i + 1 + p[i]]) 
		{
			p[i]++;
		}
		
		if (i+p[i] > range_max) 
		{
			range_max = i + p[i];
			center = i;
		}

		if (p[i] > p[longestPalindromeCenter])
		{
			longestPalindromeCenter = i;
		}
	}

	result = (char *)malloc(sizeof(char) * p[longestPalindromeCenter] + 1);
	longestPalindromeStartIndex = (longestPalindromeCenter - p[longestPalindromeCenter]) / 2;
	for (i = 0; i <  p[longestPalindromeCenter]; i++)
	{
		result[i] = s[longestPalindromeStartIndex + i];
	}
	result[p[longestPalindromeCenter]] = '\0';
	return result;
}
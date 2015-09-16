#include "stdafx.h"
#include "005-LongestPalindromicSubstring.h"


_005_LongestPalindromicSubstring::_005_LongestPalindromicSubstring()
{
}


_005_LongestPalindromicSubstring::~_005_LongestPalindromicSubstring()
{
}

string getPalindromeString(string s, int left, int right) {
	bool hasPalindromeString = false;
	while (left >= 0 && right < s.length() && s[left] == s[right])
	{
		hasPalindromeString = true;
		left--;
		right++;
	}

	return hasPalindromeString ? s.substr(left + 1, right - left - 1) : "";
}

string _005_LongestPalindromicSubstring::longestPalindrome(string s)
{
	if (s.length() <= 1) { return s; }

	string longestPalindrome = "";
	size_t longestPalindromeLength = 0;
	for (int i = 0; i < s.length() - longestPalindromeLength / 2; i++)
	{
		string palindrome = getPalindromeString(s, i, i);
		if (palindrome.length() > longestPalindromeLength)
		{
			longestPalindrome = palindrome;
			longestPalindromeLength = palindrome.length();
		}
		palindrome = getPalindromeString(s, i, i + 1);
		if (palindrome.length() > longestPalindromeLength)
		{
			longestPalindrome = palindrome;
			longestPalindromeLength = palindrome.length();
		}
	}

	return longestPalindrome;
}

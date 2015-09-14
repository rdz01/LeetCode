var solution = function() {
    'use strict';

    var getPalindromeString = function(s, left, right) {
        var hasPalindrome = false;
        while (left >= 0 && right < s.length && s[left] === s[right]) {
            hasPalindrome = true;
            left--;
            right++;
        }

        return hasPalindrome ? s.substring(left + 1, right) : "";
    };

    /**
     * @param {string} s
     * @return {string}
     */
    var longestPalindrome = function(s) {
        if (!s || s.length <= 0) {
            return s;
        }

        var longestPalindrome = "";
        var longestPalindromeLength = 0;
        for (var i = 0; i < s.length - longestPalindromeLength / 2; i++) {
            var palindrome = getPalindromeString(s, i, i);
            if (palindrome.length > longestPalindromeLength) {
                longestPalindrome = palindrome;
                longestPalindromeLength = palindrome.length;
            }
            palindrome = getPalindromeString(s, i, i + 1);
            if (palindrome.length > longestPalindromeLength) {
                longestPalindrome = palindrome;
                longestPalindromeLength = palindrome.length;
            }
        }

        return longestPalindrome;
    };

    return {
        longestPalindrome: longestPalindrome
    };
};

module.exports = solution();

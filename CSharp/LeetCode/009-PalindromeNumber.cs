namespace LeetCode
{
    public class _009_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) { return false; }

            var num = 1;
            while (x / num >= 10) { num *= 10; }

            while (x > 0)
            {
                var firstNumber = x / num;
                var lastNumber = x % 10;

                if (firstNumber != lastNumber) { return false; }

                x = x % num / 10;
                num /= 100;
            }

            return true;
        }
    }
}

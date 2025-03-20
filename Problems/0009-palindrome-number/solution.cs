public class Solution {
    public bool IsPalindrome(int x) 
    {
            int rev = 0;
            int tmp = x;
            while (tmp > 0)
            {
                rev = rev * 10 + tmp % 10;
                tmp /= 10;
            }
            return rev == x;
    }
}

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> tmp = [];
        int max = 0, j = 0;
        for (int i = 0; i < s.Length; i++) 
        {
            while (tmp.Contains(s[i]))
                tmp.Remove(s[j++]);

            tmp.Add(s[i]);
            var w = i - j + 1;
            max = max > w ? max : w;
        }
        return max;
    }
}

using System;
using System.Collections.Generic;
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var charSet = new HashSet<char>();
        int right = 0, left = 0, maxLen = 0;

        while (right < s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                right++;
                maxLen = Math.Max(maxLen, charSet.Count);
            }
            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }
        return maxLen;
    }
}
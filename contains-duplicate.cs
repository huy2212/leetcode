using System;
using System.Collections.Generic;
public class Solution
{
    public bool IsPalindrome(string s)
    {
        string forward = "";
        string backward = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                forward = forward + char.ToLower(s[i]);
                backward = char.ToLower(s[i]) + backward;
            }
        }
        return backward == forward ? true : false;
    }
}
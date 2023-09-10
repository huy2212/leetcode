using System;
using System.Collections.Generic;
public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length)
        {
            return false;
        }
        if (s.Length == 0)
        {
            return true;
        }

        int indexS = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (s[indexS] == t[i])
            {
                indexS++;
            }
            if (indexS == s.Length)
            {
                return true;
            }
        }
        return false;
    }
}
using System;
using System.Collections.Generic;
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] strings = s.Split(' ');
        var d = new Dictionary<char, string>();

        if (strings.Length != pattern.Length)
        {
            return false;
        }
        for (int i = 0; i < pattern.Length; i++)
        {
            if (!d.ContainsKey(pattern[i]))
            {
                if (d.ContainsValue(strings[i]))
                {
                    return false;
                }
                d[pattern[i]] = strings[i];
            }
            else
            {
                if (strings[i] != d[pattern[i]])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
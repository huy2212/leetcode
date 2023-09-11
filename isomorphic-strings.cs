using System;
using System.Collections.Generic;
public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var d = new Dictionary<char, char>();
        var h = new HashSet<char>();

        for (int i = 0; i < t.Length; i++)
        {
            if (!d.ContainsKey(t[i]))
            {
                if (h.Contains(s[i]))
                {
                    return false;
                }
                d[t[i]] = s[i];
                h.Add(s[i]);
            }
            else
            {
                if (s[i] != d[t[i]])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
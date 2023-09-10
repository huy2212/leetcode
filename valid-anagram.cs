using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> d = new Dictionary<char, int>();

        // Populate the dictionary with character counts from string s
        for (int i = 0; i < s.Length; i++)
        {
            if (d.ContainsKey(s[i]))
            {
                d[s[i]]++;
            }
            else
            {
                d[s[i]] = 1;
            }

            if (d.ContainsKey(t[i]))
            {
                d[t[i]]--;
            }
            else
            {
                d[t[i]] = -1;
            }
        }


        // Check if all character counts are zero
        foreach (KeyValuePair<char, int> pair in d)
        {
            if (pair.Value != 0)
            {
                return false;
            }
        }

        return true;
    }
}
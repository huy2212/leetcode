using System;
using System.Collections.Generic;
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }
        Dictionary<char, int> d = new Dictionary<char, int>();
        for (int i = 0; i < magazine.Length; i++)
        {
            if (i < ransomNote.Length)
            {
                if (!d.ContainsKey(ransomNote[i]))
                {
                    d[ransomNote[i]] = 1;
                }
                else
                {
                    d[ransomNote[i]]++;
                }
            }
            if (!d.ContainsKey(magazine[i]))
            {
                d[magazine[i]] = -1;
            }
            else
            {
                d[magazine[i]]--;
            }
        }
        foreach (KeyValuePair<char, int> pair in d)
        {
            if (pair.Value > 0)
            {
                return false;
            }
        }
        return true;
    }
}
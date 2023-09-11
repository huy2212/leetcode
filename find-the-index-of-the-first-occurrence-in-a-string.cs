using System;
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length)
        {
            return -1;
        }

        int needleIndex = 0;
        int res = -1;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (i == haystack.Length - 1 && needleIndex < needle.Length - 1)
            {
                return -1;
            }
            else if (haystack[i] == needle[needleIndex])
            {
                if (needleIndex == 0)
                {
                    res = i;
                }
                if (needleIndex == needle.Length - 1)
                {
                    return res;
                }
                needleIndex++;
            }
            else
            {
                if (res != -1)
                {
                    i = res;
                }
                needleIndex = 0;
                res = -1;
            }
        }

        return res;
    }
}
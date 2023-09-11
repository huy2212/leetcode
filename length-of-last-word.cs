using System;
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int lastWordLen = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                if (i < s.Length - 1 && char.IsLetterOrDigit(s[i + 1]))
                {
                    return lastWordLen;
                }
                else
                    continue;
            }
            else
            {
                lastWordLen++;
            }
        }
        return lastWordLen;
    }
}
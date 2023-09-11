
public class Solution
{
    static Dictionary<char, int> d = new()
        {
            {'I', 1},
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
    public int RomanToInt(string s)
    {
        int res = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (d[s[i]] < d[s[i + 1]])
            {
                res -= d[s[i]];
            }
            else
            {
                res += d[s[i]];
            }
        }
        return res + d[s[s.Length - 1]];
    }
}
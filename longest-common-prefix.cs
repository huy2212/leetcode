public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix[..^1];
                if (string.IsNullOrEmpty(prefix)) return "";
            }
        }
        return prefix;
    }
}
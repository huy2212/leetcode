public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int maxCount = 0;
        int majorityElement = 0;

        foreach (int num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 0;
            }

            dict[num]++;

            if (dict[num] > maxCount)
            {
                maxCount = dict[num];
                majorityElement = num;
            }
        }

        return majorityElement;
    }
}
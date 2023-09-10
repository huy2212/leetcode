using System;
using System.Collections.Generic;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (d.ContainsKey(target - nums[i]))
            {
                return new int[] { d[target - nums[i]], i };
            }
            if (!d.ContainsKey(nums[i]))
            {
                d.Add(nums[i], i);
            }
        }
        return new int[] { };
    }
}
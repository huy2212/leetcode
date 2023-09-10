public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int res = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[res] = nums[i];
                res += 1;
            }
            if (i < nums.Length - 1)
            {
                if (nums[i] == nums[i + 1])
                {
                    i += 1;
                }
            }
        }
        return res;
    }
}
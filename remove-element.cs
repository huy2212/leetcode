public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int res = 0;
        foreach (int num in nums)
        {
            if (num != val)
            {
                nums[res] = num;
                res++;
            }
        }
        return res;
    }
}
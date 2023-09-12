using System;
using System.Collections.Generic;
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        if (k == 0 || nums.Length == 1 || nums.Length == k)
        {
            return;
        }

        k = k % nums.Length;

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, k, nums.Length - 1);
        Reverse(nums, 0, k - 1);
    }

    public void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int tmp = arr[start];
            arr[start] = arr[end];
            arr[end] = tmp;
            start++;
            end--;
        }
    }
}
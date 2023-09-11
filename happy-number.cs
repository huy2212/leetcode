using System;
using System.Collections.Generic;
public class Solution
{
    public bool IsHappy(int n)
    {
        var set = new HashSet<int>();

        while (n != 1)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += (n % 10) * (n % 10);
                n /= 10;
            }
            if (set.Contains(sum))
            {
                return false;
            }

            set.Add(sum);
            n = sum;
        }
        return true;
    }
}
using System;
using System.Collections.Generic;
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        int len = (int)Math.Floor(Math.Log10(x) + 1);
        var st = new Stack<int>();
        for (int i = 1; i < (int)len / 2 + 1; i++)
        {
            st.Push(x % 10);
            x /= 10;
        }

        if (len % 2 == 1)
        {
            x /= 10;
        }
        while (x > 0)
        {
            if (st.Peek() == x % 10)
            {
                st.Pop();
                x /= 10;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
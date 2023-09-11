using System;
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        bool isMiss = true;
        int count_9 = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                count_9++;
            }

            if (isMiss)
            {
                digits[i] += 1;
                if (digits[i] < 10)
                {
                    return digits;
                }
                else
                {
                    digits[i] %= 10;
                }
            }
        }
        if (count_9 == digits.Length)
        {
            Array.Resize(ref digits, digits.Length + 1);
            Array.Copy(digits, 0, digits, 1, digits.Length);
            digits[0] = 1;
        }
        return digits;
    }
}
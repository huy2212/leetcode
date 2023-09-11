public class Solution
{
    public int MySqrt(int x)
    {
        long i = 1;
        while (i * i <= x)
        {

            if ((i * i) <= x && (i + 1) * (i + 1) > x)
                return (int)i;
            i++;
        }
        return 0;
    }
}
using System;

public class DivideTwoInt29
{
    public int Divide(int dividend, int divisor)
    {
        bool flag = true;
        if (dividend == divisor) return 1;

        if (dividend >= 0 && divisor < 0) flag = false;
        if (dividend < 0 && divisor > 0) flag = false;

        int n = Math.Abs(dividend);
        int d = Math.Abs(divisor);

        int ans = 0;
        while (n >= d)
        {
            int cnt = 0;

            while (n >= (d << cnt + 1))
                cnt++;

            ans += 1 << cnt;
            n = n - (d << cnt);
        }

        if (ans > Int32.MaxValue)
            return flag ? Int32.MaxValue : Int32.MinValue;

        return flag ? ans : -ans;
    }
}
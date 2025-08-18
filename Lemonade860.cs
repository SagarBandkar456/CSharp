using System;

public class Lemonade860
{
    public bool LemonadeChange(int[] bills)
    {
        int fv = 0, tn = 0;

        foreach (var item in bills)
        {
            if (item == 5) fv++;
            else if (item == 10)
            {
                if (fv == 0) return false;
                fv--;
                tn++;
            }
            else
            {
                if (fv > 0 && tn > 0)
                {
                    fv--;
                    tn--;
                }
                else if (fv > 3) fv = fv - 3;
                else return false;
            }
        }

        return true;
    }
}
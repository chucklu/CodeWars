using System;

/// <summary>
/// https://www.codewars.com/kata/compare-within-margin/train/csharp
/// </summary>
public class Kata
{
    public static int CloseCompare(double a, double b, double margin = 0)
    {
        double c = Math.Abs(a - b);
        if (c <= margin)
        {
            return 0;
        }
        if (a < b)
        {
            return -1;
        }
        return 1;
    }
}
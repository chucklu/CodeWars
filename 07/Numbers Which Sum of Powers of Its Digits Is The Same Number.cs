//http://www.codewars.com/kata/numbers-which-sum-of-powers-of-its-digits-is-the-same-number/csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Sumpowdig
{
    public static long[] EqSumPowDig(long hmax, int exp)
    {
        var list = new List<long>();
        for (long i = 2; i <= hmax; i++)
        {
            string max = i.ToString();
            long result = max.Sum(c => (long)Math.Pow(Convert.ToInt32(c.ToString(), 10), exp));
            if (result == i)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }
}
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/numbers-with-this-digit-inside/train/csharp
/// </summary>
public class Kata
{
    public static long[] NumbersWithDigitInside(long x, long d)
    {
        var list = new List<long>();
        for (long i = 1; i <= x; i++)
        {
            if (i.ToString().Contains(d.ToString()))
            {
                list.Add(i);
            }
        }
        if (list.Count == 0)
        {
            return new long[] {0, 0, 0};
        }
        return new[] {list.Count,list.Sum(),list.Aggregate(1L,(current,item)=>current*item)};
    }
}
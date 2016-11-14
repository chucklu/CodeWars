using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/number-climber/train/csharp
/// </summary>
public class Kata
{
    public static int[] Climb(int n)
    {
        var list = new List<int> { n };
        while (n > 1)
        {
            n = n / 2;
            list.Add(n);
        }
        return list.OrderBy(y => y).ToArray();
    }
}
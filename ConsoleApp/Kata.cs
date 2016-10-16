using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/even-or-odd-which-is-greater/train/csharp
/// </summary>
public class EvenOrOddKata
{
    public static string EvenOrOdd(string str)
    {
        string result;
        var numbers = str.Select(x => x - '0').ToList();
        int odd = numbers.Where(x => x % 2 == 1).Sum();
        int even = numbers.Where(x => x % 2 == 0).Sum();
        if (odd > even)
        {
            result = "Odd is greater than Even";
        }
        else if (odd == even)
        {
            result = "Even and Odd are the same";
        }
        else
        {
            result = "Even is greater than Odd";
        }
        return result;
    }
}
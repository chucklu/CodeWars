using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/get-number-from-string/train/csharp
/// </summary>
public static class Kata
{
    public static int getNumberFromString(string s)
    {
        return Convert.ToInt32(string.Join(string.Empty, s.Where(char.IsDigit)));
    }
}

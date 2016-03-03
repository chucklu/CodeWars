using System;
using System.Linq;

/// <summary>
/// http://www.codewars.com/kata/is-the-string-uppercase/csharp
/// </summary>
public static class StringExtensions
{
    public static bool isUpperCase(this string input)
    {
        return !input.Any(char.IsLower);
    }
}
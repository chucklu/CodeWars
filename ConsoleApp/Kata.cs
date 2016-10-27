using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/numbers-to-letters/train/csharp
/// </summary>
public class Kata
{
    private static readonly Dictionary<int, char> dictionary;

    static Kata()
    {
        dictionary = new Dictionary<int, char>();
        int number = 26;
        for (char c = 'a'; c <= 'z'; c++)
        {
            dictionary.Add(number--, c);
        }
        dictionary.Add(27, '!');
        dictionary.Add(28, '?');
        dictionary.Add(29, ' ');
    }

    public static string Switcher(string[] array)
    {
        return string.Concat(array.Select(n => dictionary[Convert.ToInt32(n)]));
    }
}
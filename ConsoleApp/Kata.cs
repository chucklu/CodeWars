using System;
using System.Linq;

/// <summary>
/// http://www.codewars.com/kata/sort-and-star/train/csharp
/// </summary>
public class Kata
{
    public static string TwoSort(string[] s)
    {
        Array.Sort(s, StringComparer.Ordinal);
        string temp = s.First();
        string result = string.Join("***", temp.Select(x => x));
        return result;
    }
}
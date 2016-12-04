using System;

/// <summary>
/// https://www.codewars.com/kata/sort-arrays-1/train/csharp
/// </summary>
public class Kata
{
    public static string[] SortMe(string[] names)
    {
        Array.Sort(names);
        return names;
    }
}
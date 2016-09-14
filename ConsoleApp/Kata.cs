using System;

/// <summary>
/// https://www.codewars.com/kata/string-templates-bug-fixing-number-5/train/csharp
/// </summary>
public static class Kata
{
    public static string buildString(string[] args)
    {
        foreach (string s in args)
        {
            Console.WriteLine($"s = {s},Length = {s.Length}");
        }
        return string.Format("I like {0}!", string.Join(", ", args));
    }
}
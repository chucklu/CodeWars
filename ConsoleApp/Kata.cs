using System.Collections.Generic;

/// <summary>
/// https://www.codewars.com/kata/switch-it-up/train/csharp
/// </summary>
public class Kata
{
    private static readonly List<string> list =
        new List<string> { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

    public static string SwitchItUp(int number)
    {
        return list[number];
    }
}
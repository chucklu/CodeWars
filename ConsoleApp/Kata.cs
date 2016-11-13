using System;

/// <summary>
/// https://www.codewars.com/kata/reverse-list/train/csharp
/// </summary>
public class Kata
{
    public static int[] reverseList(int[] list)
    {
        Array.Reverse(list);
        return list;
    }
}